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
    public float counter;

    public AudioSource audioPlayer2;



    // Start is called before the first frame update
    void Start()
    {
      //to write the counter beginning in 0
      cheeseAmountText.text = counter.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    //if the mouse touches a cheese, the counter add 1
    private void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("Food")){
        audioPlayer2.Play();
        Destroy(other.gameObject);
        counter += 1.0f;
        Debug.Log(counter);
        cheeseAmountText.text = counter.ToString(); 
    }
}

}

