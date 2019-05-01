using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour
{
	public void MainMenu()
	{
		SceneManager.LoadScene(1);
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(2);
	}

	public void GameCredits()
	{
		SceneManager.LoadScene(4);
	}

	public void LoadControls()
	{
		SceneManager.LoadScene(5);
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
		SceneManager.LoadScene(3);
	}

	// Button click for random racing mode, track and car
	public void RandomGameMode()
	{
		// Random.Range is exclusive for max. Hence, Random.Range(1,4)
		// will return random numbers 1,2 and 3.

		// Randomly choose a car model and the game mode to immediately race
		ChooseCar.CarType = Random.Range(1, 4);
		GameModeSelect.GameMode = Random.Range(0,2);
		SceneManager.LoadScene(3);
	}
}