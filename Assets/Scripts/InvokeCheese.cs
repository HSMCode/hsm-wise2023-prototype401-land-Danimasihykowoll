// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InvokeCheese : MonoBehaviour
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

public class InvokeCheese : MonoBehaviour
{
    public Transform player;  // Asegúrate de asignar la referencia al objeto Player en el inspector.
    public Transform spawner; // Asegúrate de asignar la referencia al objeto Spawner en el inspector.
    public float distanciaMinima; // La distancia mínima para activar el Invoke.
    public GameObject objectToSpawn;
    public Vector3 offset;
    private bool Invocated = false;

    void Update()
    {
        
        // Calcula la distancia entre el jugador y el spawner.
        float distancia = Vector3.Distance(player.position, spawner.position);

        // Verifica si la distancia es menor o igual a la distancia mínima.
        if (distancia <= distanciaMinima)
        {
            // Si la condición se cumple y aún no se ha invocado, realiza el Invoke.
            if(!Invocated)
            {

                // Si la condición se cumple, realiza el Invoke.
                Invoke("SpawnMoreObjects", 0f);
                Invocated = true;
            }
        }

        else
        {
            // Si el jugador se aleja lo suficiente, restablece la variable para permitir una nueva invocación.
            Invocated = false;
        }

    }

     void SpawnMoreObjects()
    {
     
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position+offset, transform.rotation);

    }
}



