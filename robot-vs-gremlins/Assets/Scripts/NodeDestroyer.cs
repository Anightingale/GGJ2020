using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void  Start(){
        var colliders = Physics.OverlapBox(this.transform.position, new Vector3(1.0f, 1.0f, 1.0f));
        if(colliders.Length >1){
            Debug.Log("Overlapped");
            foreach( Collider i in colliders ){
                if(i.gameObject.name == "Floor"){
                    Debug.Log("Destroyed");
                    Destroy(this.GetComponent<MapGenerator>());
                    Destroy(this);
                    break;
                }
            }
        }
    }
}
