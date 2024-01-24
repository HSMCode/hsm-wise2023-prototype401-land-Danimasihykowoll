using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public GameObject GameOverScreen; //variable for the screen
    public bool gameOver2; //bool for the activation of the screen

    // Start is called before the first frame update
    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
        //If the Game Over screen is activated and press Space, restart game
         if (Input.GetKeyDown("space") && gameOver2)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    public void restartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

    public void gameOver()
    {
        gameOver2 = true;
        GameOverScreen.SetActive(true);
    }
}
