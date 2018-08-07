using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SideWalls : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "Ball"){
					string wallName = transform.name;
          GameManager.Score(wallName);
					col.gameObject.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
				}
    }
}
