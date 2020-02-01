using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public Vector3 centre;
    public Vector3 size;
    public LayerMask grabLayer;

    ConfigurableJoint joint;

    void Start () {
        joint = gameObject.AddComponent<ConfigurableJoint>();
        joint.xMotion = ConfigurableJointMotion.Locked;
        joint.yMotion = ConfigurableJointMotion.Locked;
        joint.zMotion = ConfigurableJointMotion.Locked;
        joint.connectedBody = null;
    }

    public bool Grab ()
    {
        Collider col = CheckGrabRange();

        
        if (col != null)
        {
            joint.connectedBody = col.GetComponent<Rigidbody>();
            return true;
        }
        return false;
    }

    public void Drop ()
    {
        joint.connectedBody = null;
    }

    Collider CheckGrabRange()
    {
        Collider[] hitColliders = Physics.OverlapBox(transform.TransformPoint(centre), size / 2f, Quaternion.identity, grabLayer);

        hitColliders = GetCollidersWithRigidbody(hitColliders);
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

            Debug.Log("Grabbed: " + closest.name);
            return closest;
        }
        
        Debug.Log("Grabbed: nothing :(");
        return null;
    }

    Collider[] GetCollidersWithRigidbody (Collider[] cols)
    {
        List<Collider> col_list = new List<Collider>();

        foreach (Collider col in cols)
        {
            if (col.GetComponent<Rigidbody>() != null) 
            {
                col_list.Add(col);
            }
        }

        return col_list.ToArray();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.TransformPoint(centre), size);
    }
}
