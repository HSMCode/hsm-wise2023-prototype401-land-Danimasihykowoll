using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeCheese : MonoBehaviour
{
   
    public GameObject objectToSpawn; //variable for the object to spawn
    public Vector3 offset;
    public float repeat; //variable for the repeating time of the invoke
   

void Start()
{
    InvokeRepeating("SpawnMoreObjects", 0f, repeat);
}

void Update()
    {      

    }

     void SpawnMoreObjects()
    {
     
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

    }

   
}




