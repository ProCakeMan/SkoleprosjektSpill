using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    
    public GameObject cube;
    public Transform spawn;

    private void Start() {
        DropCube();
    }

    void DropCube(){
        Instantiate(cube, new Vector3(spawn.position.x, spawn.position.y, spawn.position.z), Quaternion.identity);
    }
}
