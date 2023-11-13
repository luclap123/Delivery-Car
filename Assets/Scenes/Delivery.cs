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
        // khi bắt đầu chạy Game, sẽ gọi đến Commpent SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("You touch a Circle");
        // Debug.Log("xin chao cac ban");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // kiểm tra xem có lướt qua package không
        if (other.tag == "Package" && !hasPackage)
        {
            // thay đổi màu cho xe
            spriteRenderer.color = hasPackageColor;
            Debug.Log("You picked a package");
            hasPackage=true;
            // làm biến mất package
            Destroy(other.gameObject, timeDestroy);

        }
        // kiểm tra xem có lướt qua locationDelivery không
        if (other.tag=="LocationDelivery" && hasPackage == true)
        {
            Debug.Log("successfully picked a location");
            hasPackage=false;
            // thay đổi màu cho xe
            spriteRenderer.color = hasNoPackageColor;
        }
    }
}
