using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{  
    public Transform player;
    Vector3 offset;

    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").transform;
    offset=player.position-transform.position;
        
    }
    //Camera should always be implemented in LateUpdate because it tracks objects.
    void LateUpdate()
    {
        transform.position=player.position-offset;
    }
}
