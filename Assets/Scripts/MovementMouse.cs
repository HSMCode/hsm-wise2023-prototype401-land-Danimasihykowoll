using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMouse : MonoBehaviour
{
    public float speed; //variable for the left movement speed

    public float sideMove; //variable for the right movement speed

    

    void Update()
    {

        // left movement
        this.transform.Translate(Vector3.left * (speed * Time.deltaTime), Space.World);


        // if the Space key is pressed, move to the right
        if (Input.GetKey(KeyCode.Space))
        {
            
            this.transform.Translate(Vector3.right * (sideMove * Time.deltaTime), Space.World);
            
        }

        

        
    }
}