using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wholeZombieDeath : MonoBehaviour
{
   
    public Transform zombpos;
    public GameObject zombpiece1;
    public GameObject zombpiece2;
    public GameObject blood;

   
    int getscore=PlayerController.score;
    int getlives=PlayerController.lives;

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
            Instantiate(zombpiece1, zombpos.position, zombpos.rotation);
            Instantiate(zombpiece2, zombpos.position, zombpos.rotation);
            Instantiate(blood, zombpos.position, zombpos.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);

            if(GameObject.FindGameObjectWithTag("Whole"));
            {
                PlayerController.score = PlayerController.score + 20;
            }
                if(GameObject.FindGameObjectWithTag("Half"));
            {
                PlayerController.score = PlayerController.score + 50;
            }
            
        }
        if (other.tag == "Player")
        {
            Instantiate(zombpiece1, zombpos.position, zombpos.rotation);
            Instantiate(zombpiece2, zombpos.position, zombpos.rotation);
            Destroy(gameObject);
            



            if(GameObject.FindGameObjectWithTag("Whole"));
            {
                PlayerController.score = PlayerController.score + 20;
            }
            if(GameObject.FindGameObjectWithTag("Half"));
            {
                PlayerController.score = PlayerController.score + 50;
            }


       
        }
    }

}
