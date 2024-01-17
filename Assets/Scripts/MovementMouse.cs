using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMouse : MonoBehaviour
{
    public float speed = 1f;

    public float sideMove = 2.0f;
    public float sideMoveFaster = 3.0f;


    void Update()
    {
        // Mueve el objeto en el eje Z
        this.transform.Translate(Vector3.forward * (speed * Time.deltaTime), Space.World);

        // Verifica si la posición en el eje Z es mayor o igual a 99.0
        if (transform.position.z >= 3.0f)
        {
            // Reposiciona el objeto en -2.5 en el eje Z
            transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        }



        // Verifica si la tecla espaciadora (Space) está siendo presionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Mueve el objeto hacia la izquierda con velocidad aumentada y cambia la dirección
            this.transform.Translate(Vector3.right * (sideMove * Time.deltaTime), Space.World);
             
        }

        if (Input.GetKey(KeyCode.Space))
        {
            // Mueve el objeto hacia la izquierda con velocidad aumentada y cambia la dirección
            this.transform.Translate(Vector3.left * (sideMoveFaster * Time.deltaTime), Space.World);   
            
        }

        
    }
}