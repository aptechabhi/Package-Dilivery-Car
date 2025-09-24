using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.01f;
    [SerializeField] float MoveSpeed = 0.01f;

    [SerializeField] float slowspeed = 10f;
    [SerializeField] float boostspeed = 20f;


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float MoveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        //transform.Rotate(0, 0, -CarAmount);
        //transform.Translate(0, MoveSpeed, 0);
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, MoveAmount, 0);
    }


    void OnCollisionEnter2D(Collision2D other)
    {

        MoveSpeed = slowspeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            MoveSpeed = boostspeed;
        }
    }
}
