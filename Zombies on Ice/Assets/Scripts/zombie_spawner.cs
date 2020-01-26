using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_spawner : MonoBehaviour
{

    public GameObject zombie;
    public Transform zombieSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(zombie, zombieSpawn.position, zombieSpawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
