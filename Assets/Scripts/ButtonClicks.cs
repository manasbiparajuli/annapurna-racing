//
// Implementation of ButtonClicks class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
public class ButtonClicks

NAME
	public class ButtonClicks - Script to load scenes based on the options that the user chooses
		in the Main Menu Scene

SYNOPSIS
	public class ButtonClicks

DESCRIPTION
	The script contains functions that load a different scene based on user's preference

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class ButtonClicks : MonoBehaviour
{

	/*
	void MainMenu()

	NAME
		MainMenu() - loads the MainMenu scene

	DESCRIPTION
		The function loads the Main Menu scene

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void MainMenu()
	{
		SceneManager.LoadScene(1);

	} /*void MainMenu()*/


	/*
	void PlayGame()

	NAME
		MainMenu() - loads the PlayGame scene

	DESCRIPTION
		The function loads the PlayGame scene

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void PlayGame()
	{
		SceneManager.LoadScene(2);

	} /*void PlayGame()*/


	/*
	void GameCredits()

	NAME
		GameCredits() - loads the GameCredits scene

	DESCRIPTION
		The function loads the Game Credits scene

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void GameCredits()
	{
		SceneManager.LoadScene(4);

	} /*void GameCredits*/


	/*
	void LoadControls()

	NAME
		LoadControls() - Displays the Game Controls scene

	DESCRIPTION
		The function loads the scene containing the information for game controls

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void LoadControls()
	{
		SceneManager.LoadScene(5);

	} /*void LoadControls() */


	/*
	void QuitGame()

	NAME
		QuitGame() - quits the game 

	DESCRIPTION
		The function exits from the game and closes the application

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void QuitGame()
	{
		// implemented exit from the Unity Editor during testing purposes
		#if UNITY_EDITOR
			// Application.Quit() does not work in the editor so
			// UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
			UnityEditor.EditorApplication.isPlaying = false;

		// Exit from the application if the game is run from the executable
		#else
			Application.Quit();
		#endif

	} /*void QuitGame() */


	//
	// Button clicks for track selections
	//

	/*
	void TrackAnnapurnaCircuit()

	NAME
		TrackAnnapurnaCircuit() - loads the Annapurna Track Circuit for the game

	DESCRIPTION
		The function loads the Annapurna Track Circuit

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void TrackAnnapurnaCircuit()
	{
		SceneManager.LoadScene(3);

	} /*void TrackAnnapurnaCircuit() */


	/*
	void RandomGameMode()

	NAME
		RandomGameMode() - Randomly choose the game mode and car

	DESCRIPTION
		The function randomly selects a game mode and a car for the race

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void RandomGameMode()
	{
		// Random.Range is exclusive for max. Hence, Random.Range(1,4)
		// will return random numbers 1,2 and 3.

		// Randomly choose a car model and the game mode to immediately race
		ChooseCar.m_CarType = Random.Range(1, 4);
		GameModeSelect.m_GameMode = Random.Range(0,2);

		// After the selections for the car and game mode, load the racing track
		SceneManager.LoadScene(3);

	} /*void RandomGameMode() */
}