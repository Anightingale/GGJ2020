using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public float grabRangeOffset;
    public Vector3 size;
    public LayerMask grabLayer;
    public LayerMask breakLayer;
    public GoblinHealth healthManager;

    ConfigurableJoint joint;
    Draggable draggable = null;
    Breakable breakable = null;


    void Start () 
    {
        joint = gameObject.AddComponent<ConfigurableJoint>();
        joint.xMotion = ConfigurableJointMotion.Locked;
        joint.yMotion = ConfigurableJointMotion.Locked;
        joint.zMotion = ConfigurableJointMotion.Locked;
        joint.connectedBody = null;
    }

    void Update ()
    {
        if (breakable != null)
        {
            if (!breakable.BreakUpdate())
            {
                breakable = null;
                if (healthManager.isSweating)
                {
                    healthManager.SweatToggle();
                }
            }
        }
    }

    public float GetModifier ()
    {
        // can't move if trying to break
        if (breakable != null)
        {
            return 0f;
        }

        // slowed if dragging
        if (draggable != null)
        {
            return draggable.dragModifier;
        }

        // normal otherwise
        return 1f;
    }

    public bool IsGrabbing ()
    {
        return ! (breakable == null && draggable == null);
    }

    public void Grab ()
    {
        // attempt to drag something
        Collider col = CheckInRange(grabLayer, ColliderIsDraggable);
        if (col != null)
        {
            // reset grab
            if (breakable != null)
            {
                breakable.BreakStop();
                breakable = null;
            }

            // we are now dragging something
            Debug.Log("Grabbed: " + col.name);
            draggable = col.GetComponent<Draggable>();
            joint.connectedBody = col.GetComponent<Rigidbody>();

            if (!healthManager.isSweating)
            {
                healthManager.SweatToggle();
            }

            return;
        }

        // attempt to pull something off if nothing to drag
        col = CheckInRange(breakLayer, ColliderIsBreakable);
        if (col != null)
        {
            // reset grab
            if (draggable != null)
            {
                draggable = null;
                joint.connectedBody = null;
            }
            if (breakable != null)
                breakable.BreakStop();

            // we are now breaking something
            breakable = col.GetComponent<Breakable>();
            breakable.BreakStart(transform.position);

            
            if (!healthManager.isSweating)
            {
                healthManager.SweatToggle();
            }

            return;
        }

        Debug.Log("Grabbed: nothing :(");
    }

    public void Drop ()
    {
        draggable = null;
        joint.connectedBody = null;

        if (breakable != null)
        {
            breakable.BreakStop();
            breakable = null;
        }

        if (healthManager.isSweating)
        {
            healthManager.SweatToggle();
        }
    }

    // declare filter higher order function
    delegate bool filterCollider(Collider col);

    // Gets the nearest collider in range that satifies the layer mask and the filter
    Collider CheckInRange(LayerMask mask, filterCollider filter)
    {
        // find all colliders in range
        Collider[] hitColliders = Physics.OverlapBox(transform.position + transform.forward * grabRangeOffset, size / 2f, transform.rotation, mask);

        // filter hitCollider list
        List<Collider> col_list = new List<Collider>();
        foreach (Collider col in hitColliders)
        {
            if (filter(col)) 
                col_list.Add(col);
        }
        hitColliders = col_list.ToArray();

        // find closest collider
        if (hitColliders.Length > 0)
        {
            Collider closest = hitColliders[0];
            float closestDist = Vector3.Distance(transform.position, closest.transform.position);
            foreach (Collider col in hitColliders)
            {
                float colDist = Vector3.Distance(transform.position, col.transform.position);
                if (colDist < closestDist) 
                {
                    closest = col;
                    closestDist = colDist;
                }
            }

            return closest;
        }
        
        // we got nothing :(
        return null;
    }

    bool ColliderIsDraggable (Collider col)
    {
        return col.GetComponent<Draggable>() != null;
    }

    bool ColliderIsBreakable (Collider col)
    {
        return col.GetComponent<Breakable>() != null;
    }



    // HANDY EDITOR STUFF
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + transform.forward * grabRangeOffset, size);
    }
}
