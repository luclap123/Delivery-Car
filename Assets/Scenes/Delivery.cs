using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("You touch a Circle");
        // Debug.Log("xin chao cac ban");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        bool a = false;
        if (other.tag == "Package")
        {
            Debug.Log("You picked a package");
            a=true;
        }
        if (other.tag=="LocationDelivery")
        {
            Debug.Log("successfully picked a location");
        }
    }
}
