using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalzombDeath : MonoBehaviour
{

    public GameObject blood;
    public Transform zombpos;

    int getlives=PlayerController.lives;
    int getscore=PlayerController.score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "shot")
        {
            Instantiate(blood, zombpos.position, zombpos.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);

               if(GameObject.FindGameObjectWithTag("Final"));
            {
                PlayerController.score = PlayerController.score + 100;
            }
            if(GameObject.FindGameObjectWithTag("HockeyZombie"));
            {
                PlayerController.score = PlayerController.score + 200;
            }

        }






        if (other.tag == "Player")
        {
            
            Instantiate(blood, zombpos.position, zombpos.rotation);
            Destroy(gameObject);

           




            if(GameObject.FindGameObjectWithTag("Final"));
            {
                PlayerController.score = PlayerController.score + 100;
            }
            if(GameObject.FindGameObjectWithTag("HockeyZombie"));
            {
                PlayerController.score = PlayerController.score + 200;
            }


        }
    }
}
