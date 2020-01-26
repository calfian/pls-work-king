using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EuclideanTorus : MonoBehaviour
{

    void Start()
    {
        
    }

 
    void Update()
    {
      if(transform.position.x > 9.5f)
        { 
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }

        else if(transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }
 
        else if(transform.position.y > 5.5f)
        {
            transform.position = new Vector3(transform.position.x, -5.5f, 0);
        }
 
        else if(transform.position.y < -5.5f)
        {
            transform.position = new Vector3(transform.position.x, 5.5f, 0);
        }  
    }
}
