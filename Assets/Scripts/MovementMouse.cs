using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMouse : MonoBehaviour
{
    public float speed;

    public float sideMove = 1.0f;

    

    void Update()
    {

        // Mueve el objeto en el eje x
        this.transform.Translate(Vector3.left * (speed * Time.deltaTime), Space.World);


        // Verifica si la tecla espaciadora (Space) está siendo presionada
        if (Input.GetKey(KeyCode.Space))
        {
            // Mueve el objeto hacia la derecha con velocidad aumentada y cambia la dirección
            this.transform.Translate(Vector3.right * (sideMove * Time.deltaTime), Space.World);
            
        }

        

        
    }
}