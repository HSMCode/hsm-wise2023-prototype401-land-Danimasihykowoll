using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


      
    

    private void OnCollisionEnter(Collision collision)
    {
     
        //when the player touches another gameObject with the tag Mango
        if (collision.gameObject.CompareTag("Player"))
        {
           
            // Destroy the mango
            Destroy(collision.gameObject);
        } 
    }
}
