using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeCheese : MonoBehaviour
{
   // public Transform player;  // variable the player
   // public Transform spawner; // variable for the spwaner
   // public float distanciaMinima; // Minimun distance to active the Invoke
    public GameObject objectToSpawn; //variable for the object to spawn
    public Vector3 offset;
    public float repeat;
   // private bool Invocated = false; //bool variable to Invoke just one cheese everytime the condition happens

//     void Update()
//     {
        
//         // to calculate the distance between the player and the spawner
//         float distancia = Vector3.Distance(player.position, spawner.position);

        
//         if (distancia <= distanciaMinima)
//         {
//             // If the condition is met, but not the invoke, do the invoke
//             if(!Invocated)
//             {
//                 Invoke("SpawnMoreObjects", 0f);
//                 Invocated = true;
//             }
//         }

//         else
//         {
//             // If the player wanders far enough away, reset the variable to allow a new invoke
//             Invocated = false;
//         }

//     }

//      void SpawnMoreObjects()
//     {
     
//         GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

//     }
// }
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




