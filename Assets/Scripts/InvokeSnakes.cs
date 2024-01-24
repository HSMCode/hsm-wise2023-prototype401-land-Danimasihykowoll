// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InvokeSnakes : MonoBehaviour
// {
//     public GameObject objectToSpawn;
//     public Vector3 offset;
//     public float iniTime;
//     public float repTime;

//     // Start is called before the first frame update
//     void Start()
//     {
//         InvokeRepeating("SpawnMoreObjects", iniTime, repTime);
//     }

//     // Update is called once per frame
//     void Update()
//     {
       
//     }

//      void SpawnMoreObjects()
//     {
     
//         GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

        

//     }

// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeSnakes : MonoBehaviour
{
    public Transform player;  // variable the player
    public Transform spawner; // variable for the spwaner
    public float distanciaMinima; // Minimun distance to active the Invoke
    public GameObject objectToSpawn; //variable for the object to spawn
    public Vector3 offset;
    private bool Invocated = false; //bool variable to Invoke just one snake everytime the condition happens

    void Update()
    {
        
        // to calculate the distance between the player and the spawner
        float distancia = Vector3.Distance(player.position, spawner.position);

    
        if (distancia <= distanciaMinima)
        {
            // If the condition is met, but not the invoke, do the invoke
            if(!Invocated)
            {

                Invoke("SpawnMoreObjects", 0f);
                Invocated = true;
            }
        }

        else
        {
            // If the player wanders far enough away, reset the variable to allow a new invoke
            Invocated = false;
        }

    }

     void SpawnMoreObjects()
    {
     
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

    }
}