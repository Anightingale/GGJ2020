using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public CameraMultiTarget cam;
    public GameObject[] targets;

    void Start()
    {
        cam.SetTargets(targets);
    }
}
