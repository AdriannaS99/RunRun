using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//dodane
using UnityEngine.UI;

public class ScoreTextHandler : MonoBehaviour
{ //For GameManager and events
   [SerializeField] 
   Text score123;  
   public GameManager player123;

    public void Start()
    {
     score123 = GameObject.FindGameObjectWithTag("SCORE1").GetComponent<Text>();
     player123 = FindObjectOfType<GameManager>();
     player123.pickupEvent += UpdateScoreText;
    }
  //Score
    public void UpdateScoreText()
    {
     score123.text="SCORE: " + player123.score; 
    }
//This function is called when the behaviour becomes disabled
//This is also called when the object is destroyed and can be used for any cleanup code
    public void OnDisable()
    {
      player123.pickupEvent -= UpdateScoreText;
    }
}
