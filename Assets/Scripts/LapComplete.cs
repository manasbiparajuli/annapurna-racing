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

	[SerializeField] public int lapsCompleted;
	[SerializeField] public float rawTime;

	private void Update()
	{
		// Check if the racer completed total game laps
		if (lapsCompleted == 1)
		{
			// activate the cutscene after race has ended
			raceComplete.SetActive(true);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		// Increment lap count as the player completes the lap
		lapsCompleted += 1;

		// Get the previous best lap time from Unity's Player Preferences
		rawTime = PlayerPrefs.GetFloat("RawTime");

		// Update the best time label only if the racers beat their previous lap time record 
		if (LapTimeManager.rawTime <= rawTime)
		{
			// Handle UI for the best lap time label
			if (LapTimeManager.secondCount <= 9)
			{
				secondLabel.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
			}
			else
			{
				secondLabel.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
			}

			if (LapTimeManager.minuteCount <= 9)
			{
				minuteLabel.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
			}
			else
			{
				minuteLabel.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ":";
			}

			milliSecLabel.GetComponent<Text>().text = "" + LapTimeManager.milliSecCount;
		}

		// save player's best lap time for future races
		PlayerPrefs.SetInt("minSave", LapTimeManager.minuteCount);
		PlayerPrefs.SetInt("secSave", LapTimeManager.secondCount);
		PlayerPrefs.SetFloat("milliSecSave", LapTimeManager.milliSecCount);
		PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

		// Reset our lap timer once the racer completes the lap
		LapTimeManager.minuteCount = 0;
		LapTimeManager.secondCount = 0;
		LapTimeManager.milliSecCount = 0;
		LapTimeManager.rawTime = 0;

		// Updated laps completed by the racer
		lapCounter.GetComponent<Text>().text = "" + lapsCompleted;

		// Activate the trigger placed at the half way of the track 
		// when lap is completed
		HalfwayTrigger.SetActive(true);
		LapCompleteTrigger.SetActive(false);
	}
}
