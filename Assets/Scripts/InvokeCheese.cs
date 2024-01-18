using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeCheese : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 offset;
    public float iniTime;
    public float repTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMoreObjects", iniTime, repTime);
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
