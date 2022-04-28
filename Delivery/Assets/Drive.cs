using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField] float steerSpeed = -300f;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float fastSpeed = 35f;

    void Start()
    {

    }


    void Update()
    {
        float steerControl = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveControl = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerControl);
        transform.Translate(0, moveControl, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = fastSpeed;
        }
    }
}
