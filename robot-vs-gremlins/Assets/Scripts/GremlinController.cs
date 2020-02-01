using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GremlinController : MonoBehaviour
{
    public float grabSpeed = 3f;

    Vector2 m_move;
    bool grabActive = false;
    float grabTime = 0f;

    void Update () {
        if (grabActive) {
            grabTime += Time.deltaTime;

            if (grabTime > grabSpeed) {
                Grab ();
                grabActive = false;
                grabTime = 0f;
            }
        }
    }

    void Grab () {
        Debug.Log("Grab success!");
    }

    public void OnMove (InputValue value) 
    {
        m_move = value.Get<Vector2>();
        Debug.Log("Move detected with value:" + m_move);
    }

    public void OnGrabStart (InputValue value) 
    {
        Debug.Log("Grab started.");
        grabActive = true;
        grabTime = 0f;
    }

    public void OnGrabStop (InputValue value) 
    {
        Debug.Log("Grab stopped.");
        grabActive = false;
        grabTime = 0f;
    }

    public void OnSpecial ()
    {
        Debug.Log("Special activated.");
    }




}
