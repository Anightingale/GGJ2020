using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GremlinController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 0.15f;
    public GrabController grabber;

    Vector2 m_move;
    Rigidbody rb;

    bool footstepsPlaying = false;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate ()
    {
        // move player
        Vector3 direction = new Vector3 (m_move.x, 0, m_move.y);
        Vector3 movement = direction * Time.fixedDeltaTime * moveSpeed * grabber.GetModifier();
        rb.MovePosition(transform.position + movement);
    }
    
    void Update () 
    {
        Vector3 direction = (new Vector3 (m_move.x, 0, m_move.y));

        // rotate player
        if (direction.magnitude > 0.1) 
        {
            if (grabber.IsGrabbing())
                direction = -direction;
            Quaternion target_rotation = Quaternion.LookRotation(direction.normalized, Vector3.up);
            
            transform.rotation = Quaternion.Slerp(transform.rotation, target_rotation, rotateSpeed);

            if (footstepsPlaying == false)
            {
                AudioManager.instance.Play("GremlinFootsteps");

                footstepsPlaying = true;
            }
        }


        if (m_move.magnitude < 0.1)
        {
            AudioManager.instance.Pause("GremlinFootsteps");
            footstepsPlaying = false;

        }

    }

    public void OnMove (InputValue value) 
    {
        m_move = value.Get<Vector2>();
    }

    public void OnGrabStart (InputValue value) 
    {
        grabber.Grab();
    }

    public void OnGrabStop (InputValue value) 
    {
        if (grabber.IsGrabbing())
        {
            grabber.Drop();
        }
    }

    public void OnSpecial ()
    {
        Debug.Log("Special activated.");
    }




}
