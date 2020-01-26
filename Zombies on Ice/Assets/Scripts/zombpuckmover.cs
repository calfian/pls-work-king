using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombpuckmover : MonoBehaviour
{
    public float speed;

    

    private float timelimit;

    public float pucktime;

    
    private Vector2 target;

    public Transform player;


    private IEnumerator coroutine;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        
        target = new Vector2(player.position.x, player.position.y);
        

        coroutine = BulletTime();
        StartCoroutine(coroutine);

        
       
    }

    private void Update()
    {
        if(player!=null)
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        else { Destroy(gameObject); }
        
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
