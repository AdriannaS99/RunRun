using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMusic : MonoBehaviour
{
    public AudioSource CoinsSound; //music for my coins
    public AudioSource BackgroundMusic; //music in the background

    //Turn on music
    public void OnMusic()
    {
       BackgroundMusic.volume=0.42f;
       CoinsSound.volume=0.18f;
    }

    //Turn off music
    public void OffMusic()
    {
        BackgroundMusic.volume =0f;
        CoinsSound.volume = 0f;
    }
  
}
