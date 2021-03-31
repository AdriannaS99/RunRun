using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool remaining_t = false;
    public int time_seconds = 125;//time in seconds
    public GameObject ShowText;
   
    void Start()
    {
        ShowText.GetComponent<Text>().text = "00:" + time_seconds;
    }
      //Ienumerator - time
    IEnumerator TimerTake()
    {
        remaining_t = true;
        //WaitForSeconds->suspends the coroutine execution for the given amount of seconds using scaled time
        yield return new WaitForSeconds(1); //Czekanie jednej sekundy zanim zacznie czas się odliczać 
        time_seconds -= 1;
        if (time_seconds < 10)
        {
            ShowText.GetComponent<Text>().text = "00:0" + time_seconds;
        }
        else 
        { 
            ShowText.GetComponent<Text>().text = "00:" + time_seconds; 
        }
        remaining_t = false;
    }

    void Update()
    {
        if(remaining_t == false && time_seconds > 0)
        {//Start coroutine
            StartCoroutine(TimerTake());
        }
      
        if(time_seconds == 0)
        {
            SceneManager.LoadScene(6); // load scene ,,Game Over" when the time=0 seconds
        }
    }

}
