//
// Implementation of GamePauseMenu class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

/*
public class GamePauseMenu

NAME
	public class GamePauseMenu: Script to display the pause menu and stop game controls

SYNOPSIS
	public class GamePauseMenu
		-> m_PausePanel: a GameObject. Contains the panel that show the pause menu
		-> m_AICar: a GameObject. Contains the AI car in the game
		-> m_PlayerCar: a GameOject. Contains the car for the racer

DESCRIPTION
	The script contains functions to activate the game pause menu panel and
	then disable car controls for both AI and player's cars. There are also functions
	to attach to buttons in the pause menu panel that allows players to display main menu and 
	restart the game.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class GamePauseMenu : MonoBehaviour
{
	[SerializeField] public GameObject m_PausePanel;
	[SerializeField] public GameObject m_AICar;
	[SerializeField] public GameObject m_PlayerCar;

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function switches between pausing and continuing the game 
		based on the player pressing the "Pause" key

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
    {
		// Display the pause menu when the player presses
		// "escape" or "p" on the keyboard
		if (Input.GetButtonDown("Pause"))
		{
			// Check if the pause panel has been activated
			// Pause the game if the pause panel has been activated
			// else, continue the game
			if (!m_PausePanel.activeInHierarchy)
			{
				PauseGame();
			}
			else
			{ 
				ContinueGame();
			}
		}
	} /*void Update() */


	/*
	PauseGame()

	NAME
		PauseGame() - function is called when the Pause menu panel is 
			activated in the game menu

	SYNOPSIS
		PauseGame()

	DESCRIPTION
		The function stops the game and disables sound as well as car controls 
		for the AI and Player cars.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void PauseGame()
	{
		// Stop the game time 
		Time.timeScale = 0;

		// Bring up the pause panel and display buttons to allow the 
		// player to choose between Main Menu and Restarting race
		m_PausePanel.SetActive(true);

		// Disable player controls when game is paused
		m_AICar.SetActive(false);
		m_PlayerCar.GetComponent<CarController>().enabled = false;
		m_PlayerCar.GetComponent<CarUserControl>().enabled = false;

		// Disable Car Engine Sounds when the game is paused
		m_PlayerCar.GetComponent<CarAudio>().StopSound();
		m_PlayerCar.GetComponent<CarAudio>().enabled = false;
		m_AICar.GetComponent<CarAudio>().StopSound();
		m_AICar.GetComponent<CarAudio>().enabled = false;

	} /* void PauseGame() */


	/*
	ContinueGame()

	NAME
		ContinueGame() - function is called when the Pause menu panel is deactivated 
			in the game menu

	SYNOPSIS
		ContinueGame()

	DESCRIPTION
		The function continues the game and enables sound as well as car controls 
		for the AI and Player cars.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void ContinueGame()
	{
		// Return the game mode to normal time scale
		Time.timeScale = 1;

		// Disable the pause panel if the player has pressed the "Pause" button 
		// for the second time
		m_PausePanel.SetActive(false);

		// Disable AI Car when the race is in Score and Time Game Mode
		// 1 = Score Mode, 2 = Time Mode
		if (GameModeSelect.m_GameMode == 1 || GameModeSelect.m_GameMode == 2)
		{
			m_AICar.SetActive(false);
		}
		// Show the AI car in Default Race Mode
		else if (GameModeSelect.m_GameMode == 0)
		{
			m_AICar.SetActive(true);
			m_AICar.GetComponent<CarAudio>().StartSound();
			m_AICar.GetComponent<CarAudio>().enabled = true;
		}

		// Enable player controls when game is continued
		m_PlayerCar.GetComponent<CarController>().enabled = true;
		m_PlayerCar.GetComponent<CarUserControl>().enabled = true;

		// Enable Car Engine Sounds when the game is continued
		m_PlayerCar.GetComponent<CarAudio>().StartSound();
		m_PlayerCar.GetComponent<CarAudio>().enabled = true;
	} /* void ContinueGame() */


	/*
	DisplayMainMenu()

	NAME
		DisplayMainMenu() - function is called when the player clicks on the Main Menu button
			in the Pause Menu panel

	SYNOPSIS
		DisplayMainMenu()

	DESCRIPTION
		The function returns the player to the main menu

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void DisplayMainMenu()
	{
		Time.timeScale = 1;
		
		// Load main menu
		SceneManager.LoadScene(1);
	} /*void DisplayMainMenu() */

	/*
	RestartRace()

	NAME
		RestartRace() - function is called when the player clicks on the 
			Restart Race button in the Pause Menu panel

	SYNOPSIS
		RestartRace()

	DESCRIPTION
		The function returns the player to the TrackAndCarSelection Scene

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void RestartRace()
	{
		Time.timeScale = 1;
	
		// Restart the race from the race track menu
		SceneManager.LoadScene(2);

	} /*void RestartRace() */
}