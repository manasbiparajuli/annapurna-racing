using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceCountdown : MonoBehaviour
{
	[SerializeField] public GameObject countDown;
	[SerializeField] public GameObject LapTimer;
	[SerializeField] public GameObject CarControls;

	[SerializeField] public AudioSource getReady;
	[SerializeField] public AudioSource goAudio;
	[SerializeField] public AudioSource levelMusic;

	void Start()
    {
		StartCoroutine(CountStart());        
    }

	IEnumerator CountStart()
	{
		// Start playing "Get Ready" audio
		// Countdown is 3
		yield return new WaitForSeconds(0.5f);
		countDown.GetComponent<Text>().text = "3";
		getReady.Play();
		countDown.SetActive(true);

		// Countdown is 2
		yield return new WaitForSeconds(1);
		countDown.SetActive(false);
		countDown.GetComponent<Text>().text = "2";
		getReady.Play();
		countDown.SetActive(true);

		// Countdown is 1
		yield return new WaitForSeconds(1);
		countDown.SetActive(false);
		countDown.GetComponent<Text>().text = "1";
		getReady.Play();
		countDown.SetActive(true);

		// Display "Go" to signal the start of race
		yield return new WaitForSeconds(1);
		countDown.SetActive(false);
		countDown.GetComponent<Text>().text = "GO!";
		countDown.SetActive(true);

		// Countdown has ended. Player can now start racing
		// Play "Go Audio" to signal the start of the race
		yield return new WaitForSeconds(0.5f);
		countDown.SetActive(false);
		goAudio.Play();
		levelMusic.Play();

		// Initiate our lap timer and allow the player to control the car
		LapTimer.SetActive(true);
		CarControls.SetActive(true);
	}
}