using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public LogicScript Logic;

    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


      
    

    private void OnCollisionEnter(Collision collision)
    {
     
        //when a snake touches another gameObject with the tag Player
        if (collision.gameObject.CompareTag("Player"))
        {
            audioPlayer.Play();
            // Destroy the player
            Destroy(collision.gameObject);
            Logic.gameOver();
        } 
    }
}
