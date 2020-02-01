using System.Collections;
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
    public CharacterController motor;
    public Animator animator;

    Vector2 m_move;
    float m_aim;

    void Update () {
        // move only in direction body is facing
        Vector3 moveDirection = new Vector3(m_move.x, 0, m_move.y);
        Vector3 movement = Vector3.Project(moveDirection * Time.deltaTime * moveSpeed, body.forward);    
        motor.Move(movement);

        // update animator
        float velocity = motor.velocity.magnitude;
        animator.SetFloat("Speed", velocity/moveSpeed);

        // rotate body
        if (m_move.magnitude > 0.1) 
        {
            Quaternion target_rotation = Quaternion.LookRotation(moveDirection.normalized, Vector3.up);
            body.rotation = Quaternion.Slerp(body.rotation, target_rotation, turnSpeed * Time.deltaTime);
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

    public void OnShoot () {
        Debug.Log("PEW PEW");
    }
}
