using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Note : MonoBehaviour
{
    Rigidbody2D rb = null;
    public float speed = 0;
    public float m = 0.25f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("w"))
        {
            m = 0.25f;
        }
        if (collision.CompareTag("b"))
        {
            m = 0.5f;
        }
        if (collision.CompareTag("g"))
        {
            m = 1.0f;
        }
        if (collision.CompareTag("p"))
        {
            m = 2.0f;
        }   
    }
}