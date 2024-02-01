using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSnake : MonoBehaviour
{
    public float move; //variable for the movement speed


    void Update()
    {
        // Movement of the snakes to go against the mouse direction
        this.transform.Translate(Vector3.back * (move * Time.deltaTime), Space.World);
    }
}