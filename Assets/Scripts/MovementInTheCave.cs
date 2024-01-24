using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInTheCave : MonoBehaviour
{
    public float speed; //variable for the starting speed
    public float faster; //variable to increase the speed
    public float maxSpeed; //variable for the max speed
    public float maxPosition; //variable to loop the movement in the cave
    public float originalPosition; //original position variable




    void Update()
    {
        
        // To move the object in the Z axis
        this.transform.Translate(Vector3.forward * (speed * Time.deltaTime), Space.World);

        // if the position in z is equal or more than the maxPosition, return to the originalPosition
        if (transform.position.z >= maxPosition) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, originalPosition);
        }
        
        //to increase the speed and make the game more difficult
        speed = speed + faster;

        //if the speed is equal or more than the maxSpeed, do not continue increasing
        if (speed >= maxSpeed)
        {
            faster = 0f;
        }

    }
}