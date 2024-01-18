using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSnake : MonoBehaviour
{
    public float speed = 3f;
    public float speed2 = 1f;


    void Update()
    {
        // Mueve el objeto en el eje x
        this.transform.Translate(Vector3.back * (speed * Time.deltaTime), Space.World);
        this.transform.Translate(Vector3.left * (speed2 * Time.deltaTime), Space.World);
        
    }
}