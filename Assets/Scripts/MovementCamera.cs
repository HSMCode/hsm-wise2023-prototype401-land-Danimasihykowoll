using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        // Mueve el objeto en el eje Z
        this.transform.Translate(Vector3.forward * (speed * Time.deltaTime), Space.World);

        // Verifica si la posición en el eje Z es mayor o igual a 99.0
        if (transform.position.z >= 0.5f)
        {
            // Reposiciona el objeto en -2.5 en el eje Z
            transform.position = new Vector3(transform.position.x, transform.position.y, -2.5f);
        }

    }
}