using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{ //for rigidbody
    private Rigidbody rb1;
 
    void Start()
    {
        //for rigidbody
    rb1 = GetComponent<Rigidbody>();
    }

    void Update()
    { //Moving objects on the plane(cube) with vector 3: 60,50,40
         transform.Rotate(new Vector3(60,50,40)*Time.deltaTime);
    }
}
