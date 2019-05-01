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
	}

	private void ContinueGame()
	{
		Time.timeScale = 1;
		PausePanel.SetActive(false);

		// Enable player controls when game is continued
		AICar.SetActive(true);
		PlayerCar.GetComponent<CarController>().enabled = true;
		PlayerCar.GetComponent<CarUserControl>().enabled = true;
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
