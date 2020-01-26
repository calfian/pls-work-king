using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private float timelimit;

    public float pucktime;

    private IEnumerator coroutine;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        coroutine = BulletTime();
        StartCoroutine(coroutine);

    }

    public IEnumerator BulletTime(float time = 2)
    {
        timelimit = time;

        while (timelimit >= 0)
        {
            yield return new WaitForSeconds(pucktime);
            timelimit--;
        }
        if (timelimit <= 0)
        {
            Destroy(gameObject);
        }

    }

   
}


