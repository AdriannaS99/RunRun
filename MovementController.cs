using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//dodane
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MovementController : MonoBehaviour
{
 private Rigidbody rb;
 public GameObject player;
 private Vector3 offset;
 public int speed;
 public int score;
 public Text myScore;
 public Text myMessage;
 private int thrust = 13;

    void Start()
    {
        //for rigidbody, to make a moving object
       rb = GetComponent<Rigidbody>();
       offset = transform.position - player.transform.position;
    }
   //When a GameObject collides with another GameObject, Unity calls OnTriggerEnter
    void OnTriggerEnter(Collider other)
    {
        //score
    Debug.Log("SCORE:"+score);
     myScore.text="Score:" +score;
     //if i collects eight objects 
        if (score==8)
        {
             Debug.Log("WIN!");
              myMessage.enabled=true;
              //next scene in 8 seconds
              Invoke("StartNewScene", 2);
        }
    }
    //method for e new scene
    private void StartNewScene(){
        Scene sceneLoad = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoad.buildIndex +1);
    }

    void Update()
    {   
        //Metoda KeyCode WASD

        //W
         if (Input.GetKey(KeyCode.W))
         {
             print("W key is held down");
         rb.AddForce(Vector3.forward * thrust );
         }
        //A
        if (Input.GetKey(KeyCode.A))
        {
            print("A key is held down");
         rb.AddForce(Vector3.left *thrust );
        
        }
        //S
         if (Input.GetKey(KeyCode.S))
         {
            print("S key is held down");
         rb.AddForce(Vector3.back * thrust );
         }

        //D
          if (Input.GetKey(KeyCode.D))
          {
              print("D key is held down");
         rb.AddForce(Vector3.right * thrust );
        
         }
        
     }   
    
 //for camera
    void LateUpdate(){
         player.transform.position = transform.position - offset;
   }
   
 }
