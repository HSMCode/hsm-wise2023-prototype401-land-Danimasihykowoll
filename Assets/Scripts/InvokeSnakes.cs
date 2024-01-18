using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeSnakes : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMoreObjects", 1.0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

     void SpawnMoreObjects()
    {
     
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

        

    }

}
