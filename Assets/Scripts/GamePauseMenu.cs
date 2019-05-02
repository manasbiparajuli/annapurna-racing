using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class GamePauseMenu : MonoBehaviour
{
	[SerializeField] public GameObject PausePanel;
	[SerializeField] public GameObject AICar;
	[SerializeField] public GameObject PlayerCar;
	
    // Update is called once per frame
    void Update()
    {
		// Display the pause menu when the player presses
		// "escape" or "p" on the keyboard
		if (Input.GetButtonDown("Pause"))
		{
			if (!PausePanel.activeInHierarchy)
			{
				PauseGame();
			}
			else
			{ 
				ContinueGame();
			}
		}
    }

	private void PauseGame()
	{
		Time.timeScale = 0;
		PausePanel.SetActive(true);

		// Disable player controls when game is paused
		AICar.SetActive(false);
		PlayerCar.GetComponent<CarController>().enabled = false;
		PlayerCar.GetComponent<CarUserControl>().enabled = false;

		// Disable Car Engine Sounds when the game is paused
		PlayerCar.GetComponent<CarAudio>().StopSound();
		PlayerCar.GetComponent<CarAudio>().enabled = false;
		AICar.GetComponent<CarAudio>().StopSound();
		AICar.GetComponent<CarAudio>().enabled = false;
	}

	private void ContinueGame()
	{
		Time.timeScale = 1;
		PausePanel.SetActive(false);

		// Disable AI Car when the race is in Score and Time Game Mode
		// 1 = Score Mode, 2 = Time Mode
		if (GameModeSelect.GameMode == 1 || GameModeSelect.GameMode == 2)
		{
			AICar.SetActive(false);
		}
		// Show the AI car in Default Race Mode
		else if (GameModeSelect.GameMode == 0)
		{
			AICar.SetActive(true);
			AICar.GetComponent<CarAudio>().StartSound();
			AICar.GetComponent<CarAudio>().enabled = true;
		}

		// Enable player controls when game is continued
		PlayerCar.GetComponent<CarController>().enabled = true;
		PlayerCar.GetComponent<CarUserControl>().enabled = true;

		// Disable Car Engine Sounds when the game is paused
		PlayerCar.GetComponent<CarAudio>().StartSound();
		PlayerCar.GetComponent<CarAudio>().enabled = true;
	}

	public void DisplayMainMenu()
	{
		Time.timeScale = 1;
		
		// Load main menu
		SceneManager.LoadScene(1);
	}

	public void RestartRace()
	{
		Time.timeScale = 1;
		// Restart the race from the race track menu
		SceneManager.LoadScene(2);
	}
}
