//
// Implementation of RaceCountdown class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class RaceCountdown

NAME
	public class RaceCountdown: Script that loads functions after the race countdown has ended

SYNOPSIS
	public class RaceCountdown
		-> m_CountDown:  a GameObject. The game object holds the panel that displays race countdown
		-> m_LapTimeManager: a GameObject. The game object holds the lap time panel
		-> m_CarControlManager: a GameObject. Holds the car controls for the player
		-> m_GetReady: an AudioSource. Holds the sound to signal countdown
		-> m_GoAudio: an AudioSource. Holds the sound to signal "Go" to the player
		-> m_LevelMusic: an AudioSource. Holds the level music.

DESCRIPTION
	The script contains functions that display the countdown and hand over controls to the racer
	when the countdown ends

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class RaceCountdown : MonoBehaviour
{
	// countdown objects
	[SerializeField] public GameObject m_CountDown;
	[SerializeField] public GameObject m_LapTimeManager;

	// car control game object
	[SerializeField] public GameObject m_CarControlManager;

	// countdown music and sound
	[SerializeField] public AudioSource m_GetReady;
	[SerializeField] public AudioSource m_GoAudio;
	[SerializeField] public AudioSource m_LevelMusic;


	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function calls the coroutine that handles countdown

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Start()
    {
		StartCoroutine(CountStart());        
    } /* void Start() */


	/*
	IEnumerator CountStart()

	NAME
		CountStart() - function is called to start the countdown

	SYNOPSIS
		CountStart()

	DESCRIPTION
		The function waits for few seconds before displaying the countdown. 
		Countdown sound is played during the countdown. When the countdown ends,
		the function activates car controls for the racer to start the race.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	IEnumerator CountStart()
	{
		// Start playing "Get Ready" audio
		// Countdown is 3
		yield return new WaitForSeconds(0.5f);
		m_CountDown.GetComponent<Text>().text = "3";
		m_GetReady.Play();
		m_CountDown.SetActive(true);

		// Countdown is 2
		yield return new WaitForSeconds(1);
		m_CountDown.SetActive(false);
		m_CountDown.GetComponent<Text>().text = "2";
		m_GetReady.Play();
		m_CountDown.SetActive(true);

		// Countdown is 1
		yield return new WaitForSeconds(1);
		m_CountDown.SetActive(false);
		m_CountDown.GetComponent<Text>().text = "1";
		m_GetReady.Play();
		m_CountDown.SetActive(true);

		// Display "Go" to signal the start of race
		yield return new WaitForSeconds(1);
		m_CountDown.SetActive(false);
		m_CountDown.GetComponent<Text>().text = "GO!";
		m_CountDown.SetActive(true);

		// Countdown has ended. Player can now start racing
		// Play "Go Audio" to signal the start of the race
		yield return new WaitForSeconds(0.5f);
		m_CountDown.SetActive(false);
		m_GoAudio.Play();
		m_LevelMusic.Play();

		// Initiate our lap timer and allow the player to control the car
		m_LapTimeManager.SetActive(true);
		m_CarControlManager.SetActive(true);

	} /* IEnumerator CountStart() */
}