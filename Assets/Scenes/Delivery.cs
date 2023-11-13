using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasNoPackageColor = new Color32(0, 0, 0, 1);
    [SerializeField] float timeDestroy;
    SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("You touch a Circle");
        // Debug.Log("xin chao cac ban");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            spriteRenderer.color = hasPackageColor;
            Debug.Log("You picked a package");
            hasPackage=true;
            Destroy(other.gameObject, timeDestroy);

        }
        if (other.tag=="LocationDelivery" && hasPackage == true)
        {
            Debug.Log("successfully picked a location");
            hasPackage=false;
            spriteRenderer.color = hasNoPackageColor;
        }
    }
}
