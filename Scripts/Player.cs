using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public float speed = 5f;
    public string upKey = "w";
    public string downKey = "s";

    private Rigidbody2D rigidbody;

    void Start(){
        
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate(){
        
        Vector2 direction  = new Vector2(0f, 0f);

        //Metoda Automatike
        // direction.x = Input.GetAxisRaw("Horizontal");
        // direction.y = Input.GetAxisRaw("Vertical");


        // Metoda Manuale
        if(Input.GetKey(upKey)){
            direction += new Vector2(0f, 1f);
        }
       
       
        if(Input.GetKey(downKey)){
            direction += new Vector2(0f, -1f);
        }

        //transform.Translate(direction * speed * Time.fixedDeltaTime);

        rigidbody.velocity = direction * speed;


    }
}
