using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Vector2 input_offset;
    public Vector2 output_offset;
    public Vector2 room_size;
    public Camera mainCamera;
    public GameObject myPlayer;
    
    void Update() {
        var playerpos = this.myPlayer.transform.position;
        mainCamera.transform.position = new Vector3(Mathf.Floor(((int)playerpos.x + input_offset.x)/room_size.x)*room_size.x + output_offset.x, mainCamera.transform.position.y, Mathf.Floor(((int)playerpos.z + input_offset.y)/room_size.y)*room_size.y + output_offset.y);
    }
}
