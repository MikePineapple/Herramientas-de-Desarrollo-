using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (transform.parent.tag == "Right")
            rb.velocity = -transform.right * speed;
        if (transform.parent.tag == "Left")
            rb.velocity = transform.right * speed;
        if (transform.parent.tag == "Up")
            rb.velocity = -transform.up * speed;
        if (transform.parent.tag == "Down")
            rb.velocity = transform.up * speed;
    }
}
