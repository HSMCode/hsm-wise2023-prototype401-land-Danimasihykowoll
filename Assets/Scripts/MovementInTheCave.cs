using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInTheCave : MonoBehaviour
{
    public float speed;
    public float faster;
    public float maxSpeed;
    public float maxPosition;
    public float originalPosition;




    void Update()
    {
        // scoreReference = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();

        // Mueve el objeto en el eje Z
        this.transform.Translate(Vector3.forward * (speed * Time.deltaTime), Space.World);

        // Verifica si la posición en el eje Z es mayor o igual a maxPosition
        if (transform.position.z >= maxPosition) 
        {
            // Reposiciona el objeto en -2.5 en el eje Z
            transform.position = new Vector3(transform.position.x, transform.position.y, originalPosition);
        }
        
       
        speed = speed + faster;

        if (speed >= maxSpeed)
        {
            faster = 0f;
        }

    }
}