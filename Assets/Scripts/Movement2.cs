using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour {

	private Rigidbody2D rb2d;
	private int speed = 8;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = rb2d.position;

		if(Input.GetKey("up"))
			transform.Translate(0, Time.deltaTime*speed ,0);
		if(Input.GetKey("down"))
			transform.Translate(0, -Time.deltaTime*speed ,0);

			if (transform.position.y <= -3.8f) {
     transform.position = new Vector2(transform.position.x, -3.8f);
 } else if (transform.position.y >= 3.8f) {
     transform.position = new Vector2(transform.position.x, 3.8f);
 }
	}
}
