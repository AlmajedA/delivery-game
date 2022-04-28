using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryPackage : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 0);
    SpriteRenderer spriteRenderer;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Whatch Out!!!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, 0.5f);
            spriteRenderer.color = hasPackageColor;
        }
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package has Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }


    }
}
