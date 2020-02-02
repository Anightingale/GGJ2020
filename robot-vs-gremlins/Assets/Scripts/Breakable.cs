using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject broken;
    public float timeToBreak = 3f;
    public float breakImpulse = 5f;
    public bool active = true;

    bool breaking = false;
    float timer = 0f;
    Vector3 force = Vector3.zero;

    void Update ()
    {
        if (active && breaking)
        {
            timer += Time.deltaTime;
            if (timer > timeToBreak)
            {
                timer = 0f;
                breaking = false;
                Break();
            }
        }
    }

    public void BreakStart(Vector3 breaker)
    {
        if (active)
        {
            timer = 0f;
            breaking = true;
            force = (breaker - transform.position).normalized;

            Debug.Log("Breaking: " + name);
        }
    }

    public void BreakStop()
    {
        if (active && breaking)
        {
            timer = 0f;
            breaking = false;

            Debug.Log("Stopped Breaking: " + name);
        }
    }

    public bool BreakUpdate ()
    {
        return breaking;
    }

    void Break()
    {
        active = false;

        GameObject new_broken = Instantiate(broken, transform.position + Vector3.up, transform.rotation);
        
        /*Rigidbody new_broken_rb = new_broken.GetComponent<Rigidbody>();
        if (new_broken_rb != null)
        {
            new_broken_rb.AddForce(force * breakImpulse, ForceMode.Impulse);
            Debug.Log(force * breakImpulse);
        }*/
        
        Debug.Log("I broke!");
        
        this.gameObject.SetActive(false);
    }
}

