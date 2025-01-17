﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RobotController : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float turnSpeed = 5f;
    public float turretSpeed = 10f;

    public Transform body;
    public Transform turret;
    public Animator animator;

    Vector2 m_move;
    float m_aim;
    Rigidbody rb;
    Vector3 lastPos;  
    float velocity = 0f;

    bool footstepsPlaying = false;

    void Start ()
    {
   
        rb = GetComponent<Rigidbody>();
        lastPos = rb.position;
    }

    void FixedUpdate ()
    {

        // move player
        Vector3 moveDirection = new Vector3(m_move.x, 0, m_move.y);
        Vector3 movement = Vector3.Project(moveDirection * Time.fixedDeltaTime * moveSpeed, body.forward);    
        rb.MovePosition(transform.position + movement);

        velocity = (rb.position - lastPos).magnitude / Time.fixedDeltaTime;
        lastPos = rb.position;
        
    }

    void Update () {
        Vector3 moveDirection = new Vector3(m_move.x, 0, m_move.y);

        // update animator
        animator.SetFloat("Speed", velocity/moveSpeed);

        // rotate body
        if (m_move.magnitude > 0.1) 
        {
            Quaternion target_rotation = Quaternion.LookRotation(moveDirection.normalized, Vector3.up);
            body.rotation = Quaternion.Slerp(body.rotation, target_rotation, turnSpeed * Time.deltaTime);

			if (footstepsPlaying == false)
            {
                AudioManager.instance.Play("RobotStartMoving");
                AudioManager.instance.Play("RobotFootsteps");
                
                footstepsPlaying = true;
            }
        }

		
        if (m_move.magnitude < 0.1)
        {
            AudioManager.instance.Pause("RobotFootsteps");
            footstepsPlaying = false;

        }

        // rotate turret
        turret.RotateAround(turret.position, turret.up, m_aim * turretSpeed * Time.deltaTime);

    }

    public void OnMove (InputValue value) 
    {
        
        m_move = value.Get<Vector2>();
       
    }

    public void OnAim (InputValue value) 
    {
        m_aim = value.Get<float>();
    }

    public void OnJump () {
        Debug.Log("Jumped!");
    }
}
