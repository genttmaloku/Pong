using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    
    public Vector2 defaultVelocity = new Vector2(5f, 2.5f);
    private Rigidbody2D rigidbody;
    private AudioSource audioSource;

    public AudioClip playerClip;
    public AudioClip wallClip;
    public AudioClip goalClip;

    void Start(){

        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        RandomizeDirection();
        

    }

    void RandomizeDirection(){
        Vector2 randomDirection = new Vector2 (1f, 1f);
        // Vector2 randomDirection = new Vector2(random.Range(-1, 1), Random.Range(-1,1));

        randomDirection.x = (Random.value <= 0.5f ? 1f : -1f);
        randomDirection.y = (Random.value <= 0.5f ? 1f : -1f);

        rigidbody.velocity =  randomDirection * defaultVelocity;
    }

    void OnCollisionEnter2D(Collision2D other){

        Vector2 direction =  new Vector2(1f, 1f);

        direction.x = (transform.position.x < 0f ?  1f : -1f);
        direction.y = (transform.position.x < 0f ?  1f : -1f);


        Vector2 currentVelocity = rigidbody.velocity;

        if(other.gameObject.CompareTag("Player")){

        currentVelocity.x =  direction.x * defaultVelocity.x;
        audioSource.PlayOneShot(playerClip); 

       }
       else if(other.gameObject.CompareTag("Wall")){

        currentVelocity.y =  direction.y * defaultVelocity.y;
        audioSource.PlayOneShot(wallClip);

       }

        rigidbody.velocity =  currentVelocity;
    }

    void OnTriggerEnter2D(Collider2D other){

        if( !other.gameObject.CompareTag("Goal"))
            return;
        //transform.position = new Vector3(0f, 0f, 0f);
        rigidbody.position =  Vector2.zero;

        RandomizeDirection();

        Goal goal = other.gameObject.GetComponent<Goal>();
        goal.AddScore();
        audioSource.PlayOneShot(goalClip);


    }
}
