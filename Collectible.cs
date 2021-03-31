using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;
using System;

public class Collectible : MonoBehaviour
{
    public int score=0;
    private AudioSource clip1;
    public static event Action score_game;

    void Start()
    {
      clip1 =GameObject.Find("SoundPick").GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(40,50,0)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
     clip1.Play();
     other.gameObject.GetComponent<MovementController>().score +=1;
     gameObject.SetActive(false);
     score_game?.Invoke();
    }
 
}
