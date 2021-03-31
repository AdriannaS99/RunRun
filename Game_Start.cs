using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Start : MonoBehaviour
{
  float speed= 50.0f;
    private GameObject start_pos; //for checkpoints

    void OnTriggerEnter(Collider other)
    {   //warning for enemy; checkpoints
        if (gameObject.CompareTag("enemy_cone"))
        {
            start_pos = GameObject.FindGameObjectWithTag("start_cone");
            other.gameObject.transform.position = start_pos.transform.position;
        }
    }
    
}
