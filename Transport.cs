using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using System;
using UnityEngine.UI;
using UnityEngine.Events;

public class Transport : MonoBehaviour
{
   public Transform teleportTarget;
   public GameObject thePlayer;
   public static event Action Min_life;

   void OnTriggerEnter(Collider other)
   {
       thePlayer.transform.position=teleportTarget.transform.position;
       Min_life?.Invoke();
       Debug.Log("-life");
   }
}
