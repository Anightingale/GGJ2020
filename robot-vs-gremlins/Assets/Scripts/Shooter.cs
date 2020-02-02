using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public ParticleSystem shootEffect;
    public LayerMask m_shootable;
    public float fireRate = 0.5f;
    public int damage = 30;

    bool fireOn = false;
    float timeSinceLastShot = 0f;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        if (fireOn && timeSinceLastShot > fireRate)
        {
            timeSinceLastShot = 0f;
            Fire();
        }
    }

    public void Shoot()
    {
        fireOn = true;
    }

    public void StopShoot()
    {
        fireOn = false;
    }

    public void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, m_shootable))
        {

            GoblinHealth gob = hit.collider.GetComponent<GoblinHealth>();
            if (gob != null)
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.blue);
                Debug.Log("hit");
                gob.TakeDamage(damage);
            }
        }   

    }
}
