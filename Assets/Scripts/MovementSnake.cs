using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSnake : MonoBehaviour
{
    public float move; //variable for the forward movement speed


    

    void Update()
    {

        // forward movement
        this.transform.Translate(Vector3.back * (move * Time.deltaTime), Space.World);

        
    }
}