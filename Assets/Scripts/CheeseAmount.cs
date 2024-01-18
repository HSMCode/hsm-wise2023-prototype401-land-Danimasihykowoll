using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseAmount : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Food"))
        {
        
            

            // Destroy the mango
            Destroy(collision.gameObject);

            //counter adds 1
            //counter = counter + 1f;

            //to update the counter in the text
             //mangoText.text = counter.ToString() + "/50";
        } 
    }
}
