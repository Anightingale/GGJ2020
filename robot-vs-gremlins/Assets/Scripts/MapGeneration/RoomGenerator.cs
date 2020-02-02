using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Aidan Fitzpatrick Melbourne Global Game jam 2020
*   Spaghetti code warning
*/

public class RoomGenerator : ScriptableObject
{

    public Vector3 roomSize;
    public float doorSize = 0;
    public int num_rooms = 0;
    public int longest_path = 0;
    public GameObject node_prefab;

    public bool north_door;
    public bool east_door;
    public bool south_door;
    public bool west_door;

    // Apologies for this big boye

    public GameObject generateRoom(
        bool north_door, bool east_door, bool south_door, bool west_door, 
        Vector3 roomSize, float doorSize, int num_rooms, 
        Material[] materials, GameObject[] obstacle_prefabs, 
        GameObject node_prefab, Camera mainCamera)
    {
        GameObject toReturn = new GameObject();

        node_prefab.GetComponent<MapGenerator>().node_prefab = node_prefab;
        node_prefab.GetComponent<MapGenerator>().roomSize = roomSize;
        node_prefab.GetComponent<MapGenerator>().doorSize = doorSize;
        node_prefab.GetComponent<MapGenerator>().num_rooms = num_rooms-1;
        node_prefab.GetComponent<MapGenerator>().longest_path = longest_path;
        node_prefab.GetComponent<MapGenerator>().materials = materials;
        node_prefab.GetComponent<MapGenerator>().obstacles = obstacle_prefabs;
        node_prefab.GetComponent<MapGenerator>().seeded = true;

        // Select a random material from the list of materials:
        if(materials.Length <= 0){
            Debug.Log("Add at least one material to the pool of materials for room generation.");
            return null;
        } 
        int mat_index = Random.Range(0, materials.Length);
        // Debug.Log("Index: " + mat_index + " For materials.length: " + materials.Length);
        Material m = materials[(int)Mathf.Floor(Random.Range(0.0f, materials.Length))];
        // North
        if(north_door){
            // generate north "door"
            GameObject wall = new GameObject();
            wall.name = "North Door";
            wall.transform.SetParent(toReturn.transform);

            var scale = new Vector3((roomSize.x-doorSize)/2.0f, roomSize.y, 1.0f);

            // Create the right wall section
            GameObject w1 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
            w1.transform.localScale = scale;
            w1.transform.localPosition = new Vector3((roomSize.x+doorSize)/4.0f,(float)(roomSize.y/2),(float)(roomSize.z/2 - 0.5));
            w1.GetComponent<Renderer>().material = m; 
            w1.transform.SetParent(wall.transform);

            // Create the left wall section
            GameObject w2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            w2.transform.localScale = scale;
            w2.transform.localPosition = new Vector3(-(roomSize.x+doorSize)/4.0f,(float)(roomSize.y/2),(float)(roomSize.z/2 - 0.5));
            w2.GetComponent<Renderer>().material = m; 
            w2.transform.SetParent(wall.transform);

            // Generate a Node
            GameObject node = Instantiate(node_prefab, new Vector3(0, 0, roomSize.z), Quaternion.identity);
            node.name = "North Node";
            node.tag = "North";
            node.transform.SetParent(toReturn.transform);
            node.GetComponent<BoxCollider>().size = roomSize;
            node.AddComponent<NodeDestroyer>();
            
            // TODO: Create a door of some kind?
        } else {
            // generate north "wall"
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "North Wall";
            wall.transform.localScale = new Vector3(roomSize.x, roomSize.y, 1.0f);
            wall.transform.localPosition = new Vector3(0.0f,(float)(roomSize.y/2),(float)(roomSize.z/2 - 0.5));

            wall.GetComponent<Renderer>().material = m; 
            wall.transform.SetParent(toReturn.transform);
        }
        // East
        if(east_door){
            // generate east "door"
            GameObject wall = new GameObject();
            wall.name = "East Door";
            wall.transform.SetParent(toReturn.transform);

            var scale = new Vector3(1.0f, roomSize.y, (roomSize.z-doorSize)/2.0f);

            // Create the right wall section
            GameObject w1 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
            w1.transform.localScale = scale;
            w1.transform.localPosition = new Vector3((float)(roomSize.x/2 - 0.5),(float)(roomSize.y/2),(roomSize.z+doorSize)/4.0f);
            w1.GetComponent<Renderer>().material = m; 
            w1.transform.SetParent(wall.transform);

            // Create the left wall section
            GameObject w2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            w2.transform.localScale = scale;
            w2.transform.localPosition = new Vector3((float)(roomSize.x/2 - 0.5),(float)(roomSize.y/2),-(roomSize.z+doorSize)/4.0f);
            w2.GetComponent<Renderer>().material = m; 
            w2.transform.SetParent(wall.transform);

            // Generate a Node
            GameObject node = Instantiate(node_prefab, new Vector3(roomSize.x, 0, 0), Quaternion.identity);
            node.name = "East Node";
            node.tag = "East";
            node.transform.SetParent(toReturn.transform);
            node.GetComponent<BoxCollider>().size = roomSize;
            node.AddComponent<NodeDestroyer>();
            
            // TODO: Create a door of some kind?
        } else {
            // generate east "wall"
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "East Wall";
            wall.transform.localScale = new Vector3(1.0f, roomSize.y, roomSize.z);
            wall.transform.localPosition = new Vector3((float)(roomSize.x/2 - 0.5), (float)(roomSize.y/2), 0.0f);

            wall.GetComponent<Renderer>().material = m; 
            wall.transform.SetParent(toReturn.transform);
        }
        // South
        if(south_door){
            // generate south "door"
            GameObject wall = new GameObject();
            wall.name = "South Door";
            wall.transform.SetParent(toReturn.transform);

            var scale = new Vector3((roomSize.x-doorSize)/2.0f, roomSize.y, 1.0f);

            // Create the right wall section
            GameObject w1 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
            w1.transform.localScale = scale;
            w1.transform.localPosition = new Vector3((roomSize.x+doorSize)/4.0f,(float)(roomSize.y/2),-(float)(roomSize.z/2 - 0.5));
            w1.GetComponent<Renderer>().material = m; 
            w1.transform.SetParent(wall.transform);

            // Create the left wall section
            GameObject w2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            w2.transform.localScale = scale;
            w2.transform.localPosition = new Vector3(-(roomSize.x+doorSize)/4.0f,(float)(roomSize.y/2),-(float)(roomSize.z/2 - 0.5));
            w2.GetComponent<Renderer>().material = m; 
            w2.transform.SetParent(wall.transform);

            // Generate a Node
            GameObject node = Instantiate(node_prefab, new Vector3(0, 0, -roomSize.z), Quaternion.identity);
            node.name = "South Node";
            node.tag = "South";
            node.transform.SetParent(toReturn.transform);
            node.GetComponent<BoxCollider>().size = roomSize;
            node.AddComponent<NodeDestroyer>();
            
            // TODO: Create a door of some kind?
        } else {
            // generate south "wall"
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "South Wall";
            wall.transform.localScale = new Vector3(roomSize.x, roomSize.y, 1.0f);
            wall.transform.localPosition = new Vector3(0.0f,(float)(roomSize.y/2),-(float)(roomSize.z/2 - 0.5));

            wall.GetComponent<Renderer>().material = m; 
            wall.transform.SetParent(toReturn.transform);
        }
        // West
        if(west_door){
            // generate west "door"
            GameObject wall = new GameObject();
            wall.name = "West Door";
            wall.transform.SetParent(toReturn.transform);

            var scale = new Vector3(1.0f, roomSize.y, (roomSize.z-doorSize)/2.0f);

            // Create the right wall section
            GameObject w1 = GameObject.CreatePrimitive(PrimitiveType.Cube); 
            w1.transform.localScale = scale;
            w1.transform.localPosition = new Vector3(-(float)(roomSize.x/2 - 0.5),(float)(roomSize.y/2),(roomSize.z+doorSize)/4.0f);
            w1.GetComponent<Renderer>().material = m; 
            w1.transform.SetParent(wall.transform);

            // Create the left wall section
            GameObject w2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            w2.transform.localScale = scale;
            w2.transform.localPosition = new Vector3(-(float)(roomSize.x/2 - 0.5),(float)(roomSize.y/2),-(roomSize.z+doorSize)/4.0f);
            w2.GetComponent<Renderer>().material = m; 
            w2.transform.SetParent(wall.transform);
            
            // Generate a Node
            GameObject node = Instantiate(node_prefab, new Vector3(-roomSize.x, 0, 0), Quaternion.identity);
            node.name = "West Node";
            node.tag = "West";
            node.transform.SetParent(toReturn.transform);
            node.GetComponent<BoxCollider>().size = roomSize;
            node.AddComponent<NodeDestroyer>();

            // TODO: Create a door of some kind?
        } else {
            // generate west "wall"
            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = "West Wall";
            wall.transform.localScale = new Vector3(1.0f, roomSize.y, roomSize.z);
            wall.transform.localPosition = new Vector3(-(float)(roomSize.x/2 - 0.5), (float)(roomSize.y/2), 0.0f);

            wall.GetComponent<Renderer>().material = m; 
            wall.transform.SetParent(toReturn.transform);
        }

        // Floor Type select (?)
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.tag = "Floor";
        floor.name = "Floor";
        floor.transform.localScale = new Vector3(roomSize.x, 1.0f, roomSize.z);
        floor.transform.localPosition = new Vector3(0, 0.5f, 0);
        floor.GetComponent<Renderer>().material = m; 
        floor.transform.SetParent(toReturn.transform);

        // Select a random obstacle prefab from the list of materials:
        if(obstacle_prefabs.Length > 0){
            int obs_index = Random.Range(0, obstacle_prefabs.Length);
            GameObject obs = Instantiate(obstacle_prefabs[(int)Mathf.Floor(Random.Range(0.0f, obstacle_prefabs.Length))]);
            obs.transform.SetParent(toReturn.transform);
        }

        toReturn.AddComponent<BoxCollider>();
        return toReturn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
