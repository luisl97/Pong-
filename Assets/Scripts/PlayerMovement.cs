using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (!isLocalPlayer)
{
    return;
}

		var y = Input.GetAxis("Vertical")*Time.deltaTime*10f;

		transform.Translate(0,y,0);
	}

	public override void OnStartLocalPlayer()
{
    GetComponent<SpriteRenderer>().color = Color.blue;
}
}
