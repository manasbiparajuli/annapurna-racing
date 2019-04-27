using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void GameCredits()
	{
		SceneManager.LoadScene(3);
	}

	public void QuitGame()
	{
		// save any game data here
		#if UNITY_EDITOR
			// Application.Quit() does not work in the editor so
			// UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}

	// Button clicks for track selections
	public void TrackAnnapurnaCircuit()
	{
		SceneManager.LoadScene(2);
	}
}
