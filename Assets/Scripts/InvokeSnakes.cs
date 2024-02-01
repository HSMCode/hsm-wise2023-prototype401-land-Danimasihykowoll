using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeSnakes : MonoBehaviour
{
    
    public GameObject objectToSpawn; //variable for the object to spawn
    public Vector3 offset;
    public float start;
    public float repeatt; //variable for the repeating time of the invoke
    

void Start()
{
    InvokeRepeating("SpawnMoreObjects", start, repeatt);
}

    void Update()
    {
        
    }

     void SpawnMoreObjects()
    {
     
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

    }
}