using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 13f;
    [SerializeField] float upSpeed = 20f;
    [SerializeField] float downSpeed = 7f;
    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        // làm cho xe di chuyển sang trái hoặc sang phải
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        // xe di chuyển tiến lên hoặc lùi xuống
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "UpSpeed")
        {
            moveSpeed = upSpeed;
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = downSpeed;
    }
}
