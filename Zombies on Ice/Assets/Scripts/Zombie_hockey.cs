using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_hockey : MonoBehaviour
{
    public float zombSpeed;

    public GameObject zombShot;
    public Transform zombshotSpawn;
   

    float x;
    float y;
    float z;
    Vector2 pos;
    private Rigidbody2D rb;

    

    private IEnumerator coroutine;

    private IEnumerator zigco;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        x = 3;
        y = 3;
        pos = new Vector2(x, y);
        rb.velocity = pos * zombSpeed;

        coroutine = shooting();
        

        zigco = zigzag();

        StartCoroutine(coroutine);
        StartCoroutine(zigco);


    }
    private void Update()
    {
      
    }


    public IEnumerator shooting(float time= 2)
    {
       
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            Instantiate(zombShot, zombshotSpawn.position, zombshotSpawn.rotation);
            

        }


    }

    public IEnumerator zigzag(float zigtime = 1)
    {
        while (zigtime > 0)
        {
            yield return new WaitForSeconds(1.5f);
            x = x * -1;
            z = x;
            x = y;
            y = z;
            
            pos = new Vector2(x, y);
            rb.velocity = pos * zombSpeed;
            z = x;
            x = y;
            y = z;
        }



    }


}
