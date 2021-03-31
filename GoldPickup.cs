using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;

public class GoldPickup : MonoBehaviour
{
    //Catch ,,$" int the level 3
    public int value;
    private AudioSource pickupsong;

    private void OnTriggerEnter(Collider other)
    {   
        if (other.tag=="Follow")//tag for my animation
        {
            FindObjectOfType<GameManager>().AddGold(value);
            Destroy(gameObject);
        }

        pickupsong.Play();
   
    }
    void Start()
    {
       pickupsong = GameObject.Find("GoldPickupSong").GetComponent<AudioSource>();
    
    }
    //to transform ,,$"
      void Update()
    {
        transform.Rotate(new Vector3(40,60,0)*Time.deltaTime);
    }
}
