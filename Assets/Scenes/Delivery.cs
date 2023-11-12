using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    bool hasPackage;
    [SerializeField] float timeDestroy;
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("You touch a Circle");
        // Debug.Log("xin chao cac ban");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("You picked a package");
            hasPackage=true;
            Destroy(other.gameObject, timeDestroy);

        }
        if (other.tag=="LocationDelivery" && hasPackage == true)
        {
            Debug.Log("successfully picked a location");
            hasPackage=false;
        }
    }
}
