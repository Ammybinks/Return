using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    Rigidbody2D rb2d;
    
    public int acceleration;
    public int maxSpeed;

    Vector2 direction;
	// Use this for initialization
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        direction = Vector2.down;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb2d.velocity += direction * acceleration * Time.deltaTime;

        if(rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        else if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

        if (rb2d.velocity.y > maxSpeed)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, maxSpeed);
        }
        else if (rb2d.velocity.y < -maxSpeed)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, -maxSpeed);
        }
    }
}
