using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackagecolor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackagecolor = new Color32(1, 1, 1, 1);
    
    [SerializeField] float delaydistroy = 0.5f; //speed of delaydistroy
    bool haspackage; //bool value for haspackage

     SpriteRenderer spriteRenderer;  //declared sprite renderer

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); //this is stored in spriterenderer
    }


    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("ohhh nooo");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !haspackage)
        {
            Debug.Log("Package picked up.");
            haspackage = true;
            spriteRenderer.color = hasPackagecolor;

            Destroy(other.gameObject, delaydistroy);//to distroy object
        }



        if (other.tag == "Customer" && haspackage)
        {
            Debug.Log("Package Deliverd");
            haspackage = false;
            spriteRenderer.color = noPackagecolor;
        }
    }

}



