using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] GameObject thingtoFollow;

     
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new Vector3(0,0,-10);
    }
}
