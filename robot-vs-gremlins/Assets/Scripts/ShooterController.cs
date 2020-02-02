using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField]
    public Shooter[] shooters;

    public void OnShoot ()
    {
        foreach (Shooter shooter in shooters)
        {
            shooter.Shoot();
        }
    }

    public void OnStopShoot()
    {
        foreach (Shooter shooter in shooters)
        {
            shooter.StopShoot();
        }

    }
}
