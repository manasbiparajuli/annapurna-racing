//
// Implementation of RaceComplete class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

/*
public class RaceComplete

NAME
	public class RaceComplete: Script that loads functions after the race has ended

SYNOPSIS
	public class RaceComplete
		-> m_PlayerCar: a GameObject. Contains the game object for the player car
		-> m_AICar: a GameObject. Contains the game object for the AI car
		-> m_RaceCompleteCamera: a GameObject. Contains the camera attached to the 
				racer that revolves around the racer's car
		-> m_CameraViewModes: a GameObject. the camera system
		-> m_LevelMusic: a GameObject. Holds the game level music
		-> m_LapCompleteTrigger: a GameObject. Holds the game object that contains collider
				to detect that the racer has completed the race
		-> m_RaceCompleteMusic: an AudioSource. Holds the audio that plays when the race ends

DESCRIPTION
	The script contains functions that disable car controls and car audio for both 
	AI and player car and then change the camera to focus on the racer's car

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class RaceComplete : MonoBehaviour
{
	[SerializeField] public GameObject m_PlayerCar;
	[SerializeField] public GameObject m_AICar;
	[SerializeField] public GameObject m_RaceCompleteCamera;
	[SerializeField] public GameObject m_CameraViewModes;
	[SerializeField] public GameObject m_LevelMusic;
	[SerializeField] public GameObject m_LapCompleteTrigger;

	[SerializeField] public AudioSource m_RaceCompleteMusic;


	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the player completes the race

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the race complete game object with the colliders attached to it.

	DESCRIPTION
		The function disables the car controls and audio of AI and player's cars. Also, it
		awards cash to the player for completing the race and then calls the coroutine that loads
		the main menu.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void OnTriggerEnter(Collider a_Other)
	{
		// Race Time Mode selected
		if (TimeMode.m_IsTimeModeSelected)
		{
		}

		else
		{
			// Disable the box collider for the race complete trigger
			this.GetComponent<BoxCollider>().enabled = false;

			// Disable car controllers after the race is completed
			m_PlayerCar.SetActive(false);
			m_AICar.SetActive(false);

			// Disable the race complete game object
			m_LapCompleteTrigger.SetActive(false);

			// Stop AI cars when race ends
			CarController.m_Topspeed = 0.0f;

			// Disable car controls for AI and the racer
			m_PlayerCar.GetComponent<CarController>().enabled = false;
			m_AICar.GetComponent<CarController>().enabled = false;
			m_PlayerCar.GetComponent<CarUserControl>().enabled = false;
			m_AICar.GetComponent<CarAIControl>().enabled = false;

			m_PlayerCar.SetActive(true);
			m_AICar.SetActive(false);

			// Stop car audio for AI and the racer
			m_PlayerCar.GetComponent<CarAudio>().StopSound();
			m_PlayerCar.GetComponent<CarAudio>().enabled = false;
			m_AICar.GetComponent<CarAudio>().StopSound();
			m_AICar.GetComponent<CarAudio>().enabled = false;

			// Hover the camera around the racer while disabling other game cameras
			m_RaceCompleteCamera.SetActive(true);
			m_CameraViewModes.SetActive(false);

			// Stop the level music and play the race complete music
			m_LevelMusic.SetActive(false);
			m_RaceCompleteMusic.Play();

			// Add race earnings to the player's profile for completing the race
			CashDisplay.m_TotalCash += 300;

			// Store the player's total earnings to Player Preferences
			PlayerPrefs.SetInt("SavedCash", CashDisplay.m_TotalCash);

			// Take the player to the main menu after the race completes
			StartCoroutine(DisplayMainMenu());

		}
	} /*void OnTriggerEnter(Collider a_Other) */


	/*
	IEnumerator DisplayMainMenu()

	NAME
		DisplayMainMenu() - function is called after the race completes

	SYNOPSIS
		DisplayMainMenu()

	DESCRIPTION
		The function waits for few seconds before loading the main menu.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	IEnumerator DisplayMainMenu()
	{
		yield return new WaitForSeconds(10);

		SceneManager.LoadScene(1);

	} /* IEnumerator DisplayMainMenu() */
}