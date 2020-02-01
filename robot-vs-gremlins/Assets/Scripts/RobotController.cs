using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RobotController : MonoBehaviour
{
    Vector2 m_move;
    Vector2 m_aim;

    public void OnMove (InputValue value) 
    {
        m_move = value.Get<Vector2>();
        Debug.Log("Move detected with value:" + m_move);
    }

    public void OnAim (InputValue value) 
    {
        m_aim = value.Get<Vector2>();
        Debug.Log("Aim detected with value:" + m_aim);
    }

    public void OnJump () {
        Debug.Log("Jumped!");
    }

    public void OnShoot () {
        Debug.Log("PEW PEW");
    }
}
