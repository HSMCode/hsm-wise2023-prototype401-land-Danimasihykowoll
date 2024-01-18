using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public GameObject GameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
    
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
        GameOverScreen.SetActive(true);
    }
}
