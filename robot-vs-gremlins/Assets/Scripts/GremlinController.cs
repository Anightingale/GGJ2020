using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GremlinController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float dragSpeed = 5f;
    public float rotateSpeed = 0.15f;
    public CharacterController motor;
    public GrabController grabber;

    Vector2 m_move;
    bool isGrabbing = false;

    void Update () 
    {
        Vector3 direction = (new Vector3 (m_move.x, 0, m_move.y));

        // move player
        float speed = isGrabbing ? dragSpeed : moveSpeed;
        Vector3 movement = direction * Time.deltaTime * speed;
        motor.Move(movement);

        // rotate player
        if (direction.magnitude > 0.1) 
        {
            if (isGrabbing)
                direction = -direction;
            Quaternion target_rotation = Quaternion.LookRotation(direction.normalized, Vector3.up);
            
            transform.rotation = Quaternion.Slerp(transform.rotation, target_rotation, rotateSpeed);
        }

    }

    public void OnMove (InputValue value) 
    {
        m_move = value.Get<Vector2>();
    }

    public void OnGrabStart (InputValue value) 
    {
        if (grabber.Grab())
        {
            isGrabbing = true;
        }
    }

    public void OnGrabStop (InputValue value) 
    {
        if (isGrabbing)
        {
            grabber.Drop();
            isGrabbing = false;
        }
    }

    public void OnSpecial ()
    {
        Debug.Log("Special activated.");
    }




}
