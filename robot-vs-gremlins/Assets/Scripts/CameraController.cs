﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*
        This is taken from a Brackeys tutorial I think
    */
    public List<Transform> targets;
 
    public Vector3 offset;
    public float smoothTime = .5f;
 
    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 50f;
 
    private Vector3 velocity;
    private Camera cam;
 
 
    private void Start()
    {
        cam = GetComponent<Camera>();
    }
 
    private void LateUpdate()
    {
        if (targets.Count == 0)
            return;
 
        move();
        zoom();
    }
 
 
 
    void move()
    {
        Vector3 centerPoint = getCenterPoint();
        Vector3 newPosition = centerPoint + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }
 
 
    Vector3 getCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }
 
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
 
        return bounds.center;
    }
    
    void zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, getGreatestDistance() / zoomLimiter);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
    }
 
    float getGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        Debug.Log(bounds.size);
        return Mathf.Max(bounds.size.x, bounds.size.z);
    }


}
