using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public int MaxScore = 0;
    public Text WinText;
    public int score = 0;
    public Action pickupEvent;
  
    void Start()
    {
        Invoke("TextNull",1);
        arrayOfObjects();
        Collectible.score_game += UpdateScore;
    }
    private void TextNull()
    {
        WinText.text= " ";
    }
    //array of objects 
    private void arrayOfObjects()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Hand");
            foreach (GameObject g in gameObjects)
        {
         MaxScore++;   
       }
    
    }
    private void UpdateScore()
    {
       CollectScore();
        if (score>=8)
        {
             Debug.Log("WIN!");
              WinText1();
              Invoke("StartNewScene", 2);
        }
    }
   private void StartNewScene()
    {
        Scene sceneLoad = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoad.buildIndex +1);
    }
    //collect score + events
    public void CollectScore()
    {
        score++;
        pickupEvent?.Invoke();
        Debug.Log("Objects. SCORE: "+score);
    }
    public void WinText1()
    {
        WinText.text = "WIN";
    }
    //On Disable function
    public void OnDisable()
    {
        Collectible.score_game -= UpdateScore;
    }
}
