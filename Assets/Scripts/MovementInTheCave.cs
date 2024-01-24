using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCave : MonoBehaviour
{
    public float speed = 1f;
    public float faster;
    public float maxSpeed;
    public float maxPosition;
    public float originalPosition;

    void Update()
    {
        // Mueve el objeto en el eje Z
        this.transform.Translate(Vector3.forward * (speed * Time.deltaTime), Space.World);

        // Verifica si la posición en el eje Z es mayor o igual a 99.0
       // if (transform.position.z <= -92.2f) //85
        if (transform.position.z >= maxPosition) //106.2
        {
            // Reposiciona el objeto en -2.5 en el eje Z
           // transform.position = new Vector3(transform.position.x, transform.position.y, 13.5f);
            transform.position = new Vector3(transform.position.x, transform.position.y, originalPosition);
        }

        speed = speed + faster;

        if (speed >= maxSpeed)
        {
            faster = 0f;
        }

    }
}