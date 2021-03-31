using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{   //OptionsPanel
    GameObject OptionsPanel;
    
    public void StartGame()
    {
    //Changing build index of scene; index nr 0->1->2->3
     Scene sceneLoad = SceneManager.GetActiveScene();
     SceneManager.LoadScene(sceneLoad.buildIndex +1);
    }
    //Options in Menu
    public void ShowOptions(bool isActive)
    {
     OptionsPanel.SetActive(isActive);
    }
    //ExitGame (Quit)
    public void ExitGame()
    {
     Application.Quit();
     //console shows ,,Exit game"
     Debug.Log("Exit game");
    }
}
