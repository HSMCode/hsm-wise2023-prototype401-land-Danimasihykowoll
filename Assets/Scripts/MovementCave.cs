using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCave : MonoBehaviour
{
    public float speed = 1f;
    public float faster;

    void Update()
    {
        // Mueve el objeto en el eje Z
        this.transform.Translate(Vector3.back * (speed * Time.deltaTime), Space.World);

        // Verifica si la posición en el eje Z es mayor o igual a 99.0
        if (transform.position.z <= -85f) //85
        {
            // Reposiciona el objeto en -2.5 en el eje Z
            transform.position = new Vector3(transform.position.x, transform.position.y, 13.5f);
        }

        speed = speed + faster;

    }
}