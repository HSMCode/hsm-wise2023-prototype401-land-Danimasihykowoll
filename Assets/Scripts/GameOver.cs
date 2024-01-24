using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public LogicScript Logic; //variable to find the gameOver void

    public AudioSource audioPlayer; //audio variable

    public AudioSource AudioPlayer3; //audio variable

    public ParticleSystem mouse; //particles variable


    // Start is called before the first frame update
    void Start()
    {
        //locating the gameOver void in LogicScript 
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
            mouse.Play();
            Destroy(collision.gameObject);
            Logic.gameOver();
            AudioPlayer3.Stop();
        } 
    }
}
