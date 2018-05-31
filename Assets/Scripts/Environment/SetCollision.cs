using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCollision : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        BoxCollider2D collider = gameObject.GetComponent<BoxCollider2D>();

        collider.size = new Vector2(renderer.size.x - (float)0.1, renderer.size.y - (float)0.1);
    }
}
