using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour {

	public static int PlayerScore1 = 0;
	public static int PlayerScore2 = 0;

	public GUISkin layout;

	public GameObject theBall;

	// Use this for initialization
	void Start () {
		theBall = GameObject.FindGameObjectWithTag("Ball");

	}

	// Update is called once per frame
	void Update () {

	}

	public static void Score(string Wall){
		if(Wall == "LeftWall"){
			PlayerScore2++;
		} else {
			PlayerScore1++;
		}
	}

	void OnGUI () {
    GUI.skin = layout;
    GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + PlayerScore1);
    GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + PlayerScore2);

    if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        theBall.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
    }

}
}
