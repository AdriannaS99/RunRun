using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
   //change to next scene
       public void ChangeToScene(int ChangeToScene)
    {
          if (SceneManager.GetActiveScene().name == "SampleScene"){
             SceneManager.LoadScene("Menu", LoadSceneMode.Single);}
    }
}
