using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {


	private int rally = 0;

	private Rigidbody2D rb2d;



	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
			if (rally == 7){
				Vector2 vel;
				vel.x = rb2d.velocity.x/2f;
				vel.y = rb2d.velocity.y/2f;
				rb2d.velocity = vel;
				rally = 0;
			}

	}

	void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.CompareTag("Paddle")){
					Vector2 vel;
					vel.x = rb2d.velocity.x + (col.collider.attachedRigidbody.velocity.y / 2);
					vel.y = (rb2d.velocity.y) + (col.collider.attachedRigidbody.velocity.y / 3);
					rb2d.velocity = vel;
					rally++;
				}
    }

		void ResetBall(){
			rb2d.velocity = Vector2.zero;
			transform.position = Vector2.zero;
		}

		void RestartGame(){
			ResetBall();
			Invoke("StartGame", 1);
		}

		void StartGame(){
			float rand = Random.Range(0, 2);
	    if(rand < 1){
	        rb2d.AddForce(new Vector2(20, -15));
	    } else {
	        rb2d.AddForce(new Vector2(-20, -15));
	    }
		}
}
