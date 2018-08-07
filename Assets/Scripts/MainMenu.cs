using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayLocal ()
	{
		 SceneManager.LoadScene("Local");
	}

	public void PlayOnline ()
	{
		Debug.Log("Online");
		 SceneManager.LoadScene("Online");
	}
}
