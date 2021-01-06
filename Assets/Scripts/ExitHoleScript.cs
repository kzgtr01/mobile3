using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitHoleScript : MonoBehaviour {

	// If ball touches Exit holes collider
	// then youWin variable of BallControlScript is set to true
	public void OnTriggerEnter2D (Collider2D col)
	{
		BallControlScript.setYouWinToTrue ();
		Scene currentScene = SceneManager.GetActiveScene();
		string scenename = currentScene.name;

		if (scenename == "RB5"){
			SceneManager.LoadScene("Win");
		}
	}
}
