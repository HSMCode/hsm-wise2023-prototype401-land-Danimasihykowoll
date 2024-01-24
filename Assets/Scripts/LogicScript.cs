using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public GameObject GameOverScreen;
    public bool gameOver2;

    // Start is called before the first frame update
    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("space") && gameOver2)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    public void restartGame()
    {
        // if (Input.GetKeyDown("space"))
        // {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // }
    }

    public void gameOver()
    {
        gameOver2 = true;
        GameOverScreen.SetActive(true);
    }
}
