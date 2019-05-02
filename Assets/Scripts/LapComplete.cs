using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
	[SerializeField] GameObject LapCompleteTrigger;
	[SerializeField] GameObject HalfwayTrigger;

	[SerializeField] public GameObject minuteLabel;
	[SerializeField] public GameObject secondLabel;
	[SerializeField] public GameObject milliSecLabel;

	[SerializeField] public GameObject lapCounter;

	[SerializeField] public GameObject raceComplete;

	[SerializeField] private int lapsCompleted = 0;
	[SerializeField] public float rawTime = 0f;

	public static bool isRaceComplete = false;

	private void Update()
	{
		// Check if the racer completed total game laps
		if (lapsCompleted == 2)
		{
			UpdateLapTimeLabel();

			isRaceComplete = true;

			// Update the lap time if the racer improved their lap time record
			UpdateLapTimeLabel();

			// activate the cutscene after race has ended
			raceComplete.SetActive(true);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		// Increment lap count as the player completes the lap
		lapsCompleted++;

		// Updated laps completed by the racer
		lapCounter.GetComponent<Text>().text = "" + lapsCompleted.ToString();

		// Update the lap time if the racer improved their lap time record
		UpdateLapTimeLabel();

		// Activate the trigger placed at the half way of the track 
		// when lap is completed
		HalfwayTrigger.SetActive(true);
		LapCompleteTrigger.SetActive(false);

		// Reset the raw time after the lap is completed
		LapTimeManager.rawTime = 0f;
	}

	private void UpdateLapTimeLabel()
	{
		// Get the previous best lap time from Unity's Player Preferences
		rawTime = PlayerPrefs.GetFloat("RawTime");
		Debug.Log(PlayerPrefs.GetFloat("RawTime"));

		// Update the best time label only if the racers beat their previous lap time record 
		if (LapTimeManager.rawTime <= rawTime)
		{
			// Handle UI for the best lap time label
			if (LapTimeManager.secondCount <= 9)
			{
				secondLabel.GetComponent<Text>().text = "0" + LapTimeManager.secondCount.ToString() + ".";
			}
			else
			{
				secondLabel.GetComponent<Text>().text = "" + LapTimeManager.secondCount.ToString() + ".";
			}

			if (LapTimeManager.minuteCount <= 9)
			{
				minuteLabel.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount.ToString() + ":";
			}
			else
			{
				minuteLabel.GetComponent<Text>().text = "" + LapTimeManager.minuteCount.ToString() + ":";
			}

			milliSecLabel.GetComponent<Text>().text = "" + LapTimeManager.milliSecCount.ToString();


			// save player's best lap time for future races
			PlayerPrefs.SetInt("minSave", LapTimeManager.minuteCount);
			PlayerPrefs.SetInt("secSave", LapTimeManager.secondCount);
			PlayerPrefs.SetFloat("milliSecSave", LapTimeManager.milliSecCount);
			PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);
		}

		// Reset our lap timer once the racer completes the lap
		LapTimeManager.minuteCount = 0;
		LapTimeManager.secondCount = 0;
		LapTimeManager.milliSecCount = 0.0f;
		LapTimeManager.rawTime = 0.0f;
	}
}
