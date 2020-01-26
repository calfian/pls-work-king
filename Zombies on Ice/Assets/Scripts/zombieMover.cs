using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMover : MonoBehaviour
{
    private float zombSpeed;

    float x;
    float y;
    Vector2 pos;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        zombSpeed = Random.Range(0.1f, 0.275f);
        x = Random.Range(-10, 10);
        y = Random.Range(-10, 10);
        pos = new Vector2(x, y);
        rb.velocity = pos * zombSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
