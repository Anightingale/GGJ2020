using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Vector3 roomSize;
    public float doorSize = 0;
    public int num_rooms = 40;
    public int longest_path = 0;
    public GameObject node_prefab;
    public Camera main_camera;

    public Material[] floor_materials;
    public Material[] wall_materials;
    public GameObject[] obstacles;

    public int seed;
    public bool seeded = false;

    // North = (True,x,x,x)
    // East  = (x,True,x,x)
    // South = (x,x,True,x)
    // West  = (x,x,x,True)

    private RoomGenerator roomGenerator;
    private bool spawned = false;

    // Start is called before the first frame update
    void Start(){
        roomGenerator = ScriptableObject.CreateInstance(typeof(RoomGenerator)) as RoomGenerator;
        if(!seeded){
            if(seed != 0){
                Random.InitState(seed);    
            }
            seeded = true;
        }
        if(this.CompareTag("Rooms") == true){
            GameObject startRoom = roomGenerator.generateRoom(true, true, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
            startRoom.transform.SetParent(this.transform);
        } else {
            //Start generateRoom on a delay
            Invoke("generateRoom", 0.1f);
        }
    }


    // I am not sorry for the below.
    void generateRoom(){
        if(spawned == true || this.num_rooms < 1){
            Destroy(gameObject);
            return;
        }

        int openingDir = -1;
        if(this.CompareTag("North")){
            // South Opening
            openingDir = 2;
        } else if(this.CompareTag("East")){
            // West Opening
            openingDir = 3;
        } else if (this.CompareTag("South")) {
            // North Opening
            openingDir = 0;
        } else if (this.CompareTag("West")){
            // East Opening
            openingDir = 1;
        }

        // This is a silly way to to do this -- don't need to Instantiate the GameObject since it is already in the scene...

        if(this.num_rooms == 1){
            if(openingDir == 0){
                // North
                GameObject room = roomGenerator.generateRoom(true, false, false, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
            } else if(openingDir == 1){
                // East
                GameObject room = roomGenerator.generateRoom(false, true, false, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
            } else if(openingDir == 2){
                // South
                GameObject room = roomGenerator.generateRoom(false, false, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
            } else if(openingDir == 3){
                // West
                GameObject room = roomGenerator.generateRoom(false, false, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
            }
            spawned = true;
            return;
        }

        float num = Random.Range(0.0f,1.0f);
        int numExits = 0;
        if (0.3 < num && num <= 1){
            numExits = 1;
        } else if (num <= 1){
            numExits = 2;
        }

        if(openingDir == 0){
            // North
            var exitDir = Random.Range(0,3);
            if( exitDir < 1 ){
                if(numExits == 1){
                    // Exit East
                    GameObject room = roomGenerator.generateRoom(true, true, false, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit East + West
                    GameObject room = roomGenerator.generateRoom(true, true, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 2){
                if(numExits == 1){
                    // Exit South
                    GameObject room = roomGenerator.generateRoom(true, false, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit South + East
                    GameObject room = roomGenerator.generateRoom(true, true, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 3) {
                if(numExits == 1){
                    // Exit West
                    GameObject room = roomGenerator.generateRoom(true, false, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit West + South
                    GameObject room = roomGenerator.generateRoom(true, false, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            }
        } else if (openingDir == 1){
            // East
            var exitDir = Random.Range(0,3);
            if( exitDir < 1 ){
                if(numExits == 1){
                    // Exit North
                    GameObject room = roomGenerator.generateRoom(true, true, false, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit North + West
                    GameObject room = roomGenerator.generateRoom(true, true, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 2){
                if(numExits == 1){
                    // Exit South
                    GameObject room = roomGenerator.generateRoom(false, true, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit South + North
                    GameObject room = roomGenerator.generateRoom(true, true, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 3) {
                if(numExits == 1){
                    // Exit West
                    GameObject room = roomGenerator.generateRoom(false, true, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit West + South
                    GameObject room = roomGenerator.generateRoom(false, true, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            }
        } else if (openingDir == 2){
            // South
            var exitDir = Random.Range(0,3);
            if( exitDir < 1 ){
                if(numExits == 1){
                    // Exit North
                    GameObject room = roomGenerator.generateRoom(true, false, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit North + West
                    GameObject room = roomGenerator.generateRoom(true, false, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 2){
                if(numExits == 1){
                    // Exit East
                    GameObject room = roomGenerator.generateRoom(false, true, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit East + North
                    GameObject room = roomGenerator.generateRoom(true, true, true, false, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 3) {
                if(numExits == 1){
                    // Exit West
                    GameObject room = roomGenerator.generateRoom(false, false, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit West + East
                    GameObject room = roomGenerator.generateRoom(false, true, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            }
        } else if (openingDir == 3){
            // West
            var exitDir = Random.Range(0,3);
            if( exitDir < 1 ){
                if(numExits == 1){
                    // Exit North
                    GameObject room = roomGenerator.generateRoom(true, false, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit North + South
                    GameObject room = roomGenerator.generateRoom(true, false, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 2){
                if(numExits == 1){
                    // Exit East
                    GameObject room = roomGenerator.generateRoom(false, true, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit East + North
                    GameObject room = roomGenerator.generateRoom(true, true, false, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            } else if (exitDir < 3) {
                if(numExits == 1){
                    // Exit South
                    GameObject room = roomGenerator.generateRoom(false, false, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                } else if (numExits == 2){
                    // Exit South + East
                    GameObject room = roomGenerator.generateRoom(false, true, true, true, roomSize, doorSize, num_rooms, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                    Instantiate(room, this.transform.position, Quaternion.identity);
                    Destroy(room);
                    Destroy(gameObject);
                }
            }
        }

        spawned = true;
    }

    void OnTriggerStay(Collider other){
        OnTriggerEnter(other);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Floor") == true){
            Debug.Log("Destroyed.");
            Destroy(gameObject);
        }

        if(other.CompareTag("North")){
            // South Opening
            if(this.CompareTag("East")){
                GameObject room = roomGenerator.generateRoom(true, true, false, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("South")){
                GameObject room = roomGenerator.generateRoom(true, false, true, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("West")){
                GameObject room = roomGenerator.generateRoom(true, false, false, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            }
        } else if (other.CompareTag("East")){
            // West Opening
            if(this.CompareTag("North")){
                GameObject room = roomGenerator.generateRoom(true, true, false, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("South")){
                GameObject room = roomGenerator.generateRoom(false, true, true, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("West")){
                GameObject room = roomGenerator.generateRoom(false, true, false, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            }
        } else if (other.CompareTag("South")){
            // North Opening
            if(this.CompareTag("East")){
                GameObject room = roomGenerator.generateRoom(false, true, true, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("North")){
                GameObject room = roomGenerator.generateRoom(true, false, true, false, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("West")){
                GameObject room = roomGenerator.generateRoom(false, false, true, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            }
        } else if (other.CompareTag("West")){
            // East Opening
            if(this.CompareTag("East")){
                GameObject room = roomGenerator.generateRoom(false, true, false, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("South")){
                GameObject room = roomGenerator.generateRoom(false, false, true, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            } else if (this.CompareTag("North")){
                GameObject room = roomGenerator.generateRoom(true, false, false, true, roomSize, doorSize, 0, floor_materials, wall_materials, obstacles, node_prefab, main_camera);
                Instantiate(room, this.transform.position, Quaternion.identity);
                Destroy(room);
                Destroy(gameObject);
                Destroy(other);
            }
        }
    }
}
