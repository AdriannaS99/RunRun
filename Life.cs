using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;

public class Life : MonoBehaviour
{ 
    [SerializeField] Text Life_text;
    private GameManager player_m;

    void Start()
    {
        Life_text = GameObject.FindGameObjectWithTag("LifeAnim").GetComponent<Text>();
        player_m = FindObjectOfType<GameManager>();
        player_m.Minus_life += UpdateLifeScore;
    }

    private void UpdateLifeScore()
    {
       //Life_text.text = "Life: ";
        Life_text.text = "";
        for (int i = 0; i < player_m.life_score; i++)
        {
            Life_text.text += "❤";
        }
    }

    private void OnDisable()
    {
    player_m.Minus_life -= UpdateLifeScore;
    }

    
}
