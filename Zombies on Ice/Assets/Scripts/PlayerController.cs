using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
  float rotationSpeed = 200.0f;
    public float thrustForce = 3f;

    public float fireRate;
    private float nextFire;
    public static int lives = 3;
    public static int score = 0;

    public Text liveText;

    private SpriteRenderer playerSprite;

    private BoxCollider2D playerColidder;

    private bool dead = false;
        

    public AudioSource musicSource;
    public AudioClip PlayerDeath; 



    public GameObject shot;
    public Transform shotSpawn;

    private Rigidbody2D rb;

    public GameObject blood;

    private Transform self;

    private IEnumerator deathWait;

    public Transform hockey;
    
 
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
        playerColidder = GetComponent<BoxCollider2D>();
        playerSprite = GetComponent<SpriteRenderer>();
      self = GetComponent<Transform>();
        deathWait = PlayerdeathWait();

        liveText.text = lives.ToString();

        hockey = GetComponent<Transform>();
      
    }
 
    void FixedUpdate () 
    {
      transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*rotationSpeed * Time.deltaTime); 
      rb.AddForce(transform.up * thrustForce *Input.GetAxis("Vertical"));


    }

  void  Update()
    {
        liveText.text = lives.ToString();

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            int y = Random.Range(-5, 5);
            hockey.position = new Vector3(Random.Range(-9, 9),y, 0);
        }
        

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
          nextFire = Time.time + fireRate;
          Instantiate(shot, shotSpawn.position, shotSpawn.rotation);           
        }


        if (lives == 2)
        {
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            Destroy(GameObject.FindGameObjectWithTag("Puck3"));

        }

        if (lives == 1)
        {
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            Destroy(GameObject.FindGameObjectWithTag("Puck2"));
        }

        



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "zombShot")
      {
        lives = lives -1;
        Instantiate(blood, self.position, self.rotation);
            dead = true;
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            StartCoroutine(PlayerdeathWait());
            Destroy(other.gameObject);
            
            

        if (lives == 0)
        {
          Instantiate(blood, self.position, self.rotation);
                musicSource.clip = PlayerDeath;
                musicSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Puck1"));
                Destroy(gameObject);
            }    
      }
      if (other.tag == "HockeyZombie")
        {
            lives = lives - 1;
            Instantiate(blood, self.position, self.rotation);
            dead = true;
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            StartCoroutine(PlayerdeathWait());
            Destroy(other.gameObject);

            if (lives == 0)
            {
                Instantiate(blood, self.position, self.rotation);
                musicSource.clip = PlayerDeath;
                musicSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Puck1"));
                Destroy(gameObject);
            }
        }

        if (other.tag == "Whole")
        {
            lives = lives - 1;
            
            Instantiate(blood, self.position, self.rotation);
            dead = true;
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            StartCoroutine(PlayerdeathWait());
            Destroy(other.gameObject);

            if (lives == 0)
            {
                Instantiate(blood, self.position, self.rotation);
                musicSource.clip = PlayerDeath;
                musicSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Puck1"));
                Destroy(gameObject);
            }
        }
        if (other.tag == "Half")
        {
            lives = lives - 1;
            Instantiate(blood, self.position, self.rotation);
            dead = true;
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            StartCoroutine(PlayerdeathWait());
            Destroy(other.gameObject);

            if (lives == 0)
            {
                Instantiate(blood, self.position, self.rotation);
                musicSource.clip = PlayerDeath;
                musicSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Puck1"));
                Destroy(gameObject);
            }
        }
        if (other.tag == "Final")
        {
            lives = lives - 1;
            Instantiate(blood, self.position, self.rotation);
            dead = true;
            musicSource.clip = PlayerDeath;
            musicSource.Play();
            StartCoroutine(PlayerdeathWait());
            Destroy(other.gameObject);

            if (lives == 0)
            {
                Instantiate(blood, self.position, self.rotation);
                musicSource.clip = PlayerDeath;
                musicSource.Play();
                Destroy(GameObject.FindGameObjectWithTag("Puck1"));
                Destroy(gameObject);
            }
        }
    }


    public IEnumerator PlayerdeathWait()
    {
        while (dead == true)
        {
            playerColidder.enabled = false;
            playerSprite.enabled = false;
            yield return new WaitForSeconds(2);
            gameObject.transform.position = new Vector3(0, 0, 0);
            playerSprite.enabled = true;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = false;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = true;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = false;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = true;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = false;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = true;
            yield return new WaitForSeconds(0.2f);
            playerSprite.enabled = false;
            yield return new WaitForSeconds(0.2f);

            playerSprite.enabled = true;
            playerColidder.enabled = true;
            dead = false;

        }
       
    }


   


}
