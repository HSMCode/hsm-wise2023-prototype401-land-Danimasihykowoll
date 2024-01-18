using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static bool win = false;
    //Variable for text (amount of cheeses)
    public TMP_Text cheeseAmountText;

    //Variable for the counter
    public float counter = 0f;

    public AudioSource audioPlayer2;


    // Start is called before the first frame update
    void Start()
    {
      //to write the counter beginning in 0/50
      cheeseAmountText.text = counter.ToString(); // + "/10";   
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
     
       
        //when the player touches another gameObject with the tag Food
        if (collision.gameObject.CompareTag("Food"))
        {
        
            
            audioPlayer2.Play();
            // Destroy the cheese
            Destroy(collision.gameObject);
            counter = counter + 1f;
            cheeseAmountText.text = counter.ToString(); //+ "/10";


        } 

        // if (counter >= 10)
        // {
        //     cheeseAmountText.text = "10/10";
        //     win = true;
        // }
    }

}

