//
// Implementation of LapComplete class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class LapComplete

NAME
	public class LapComplete: Script that handles activation of halfway object while 
		disabling finish line game objects. The class also updates the lap time label by
		updating the best time lap label and resetting the lap time

SYNOPSIS
	public class LapComplete
		-> m_LapCompleteTrigger: a GameObject. Contains the finish line game object
		-> m_HalfwayTrigger: a GameObject. Contains the halfway line game object
		-> m_MinuteLabel: a GameObject. The label to display minute
		-> m_SecondLabel: a GameObject. The label to display second
		-> m_MilliSecLabel: a GameObject. The label to display millisecond
		-> m_LapCounter: a GameObject. The label to display the current lap in the race
		-> m_RaceComplete: a GameObject. The game object that holds the finish line object
		-> m_LapsCompleted: an integer. The counter for the total laps completed by the racer
		-> m_RawTime: a float. The time passed after the game has started.
		-> m_IsRaceComplete: a bool. Check if the race has completed to stop the lap timer

DESCRIPTION
	The script contains function to deactivate the finish line gameobject and enable the halfway 
	track game object when the racer passes through the finish line. There are also functions to 
	reset the lap time label and updates the best lap time label when the racer finishes the laps

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class LapComplete : MonoBehaviour
{
	// the triggers setup around the race track
	[SerializeField] GameObject m_LapCompleteTrigger;
	[SerializeField] GameObject m_HalfwayTrigger;

	// the labels for the lap time
	[SerializeField] public GameObject m_MinuteLabel;
	[SerializeField] public GameObject m_SecondLabel;
	[SerializeField] public GameObject m_MilliSecLabel;

	// the label for the lap count
	[SerializeField] public GameObject m_LapCounter;

	// the gameobject that contains the finish line objects
	[SerializeField] public GameObject m_RaceComplete;

	// the lap counter
	[SerializeField] private int m_LapsCompleted = 0;

	// the total time passed since the race has started
	[SerializeField] public float m_RawTime = 0f;

	// flag to know if the race has been completed
	public static bool m_IsRaceComplete = false;


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function checks if the race has been completed and if so, activates the final
		lap time game object.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
	{
		// Check if the racer completed total game laps
		if (m_LapsCompleted == 2)
		{
			UpdateLapTimeLabel();

			m_IsRaceComplete = true;

			// Update the lap time if the racer improved their lap time record
			UpdateLapTimeLabel();

			// activate the cutscene after race has ended
			m_RaceComplete.SetActive(true);
		}
	}/* void Update() */


	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the player passes through the final lap line trigger

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the final lap line object with the colliders attached to it.

	DESCRIPTION
		The function enables deactivates the finishing line game object while enabling the halfway line 
		game object once the player passes through the finish line object collider

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void OnTriggerEnter(Collider a_Other)
	{
		// Increment lap count as the player completes the lap
		m_LapsCompleted++;

		// Update laps completed by the racer
		m_LapCounter.GetComponent<Text>().text = "" + m_LapsCompleted.ToString();

		// Update the lap time if the racer improved their lap time record
		UpdateLapTimeLabel();

		// Activate the trigger placed at the half way of the track 
		// when lap is completed
		m_HalfwayTrigger.SetActive(true);
		m_LapCompleteTrigger.SetActive(false);

		// Reset the raw time after the lap is completed
		LapTimeManager.m_RawTime = 0f;

	} /* void OnTriggerEnter(Collider a_Other) */


	/*
	UpdateLapTimeLabel()

	NAME
		UpdateLapTimeLabel() - function is called after the race ends

	SYNOPSIS
		UpdateLapTimeLabel()

	DESCRIPTION
		The function udpates the best lap time label after the race 
		has been completed.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void UpdateLapTimeLabel()
	{
		// Get the previous best lap time from Unity's Player Preferences
		m_RawTime = PlayerPrefs.GetFloat("RawTime");
		Debug.Log(PlayerPrefs.GetFloat("RawTime"));

		// Update the best time label only if the racers beat their previous lap time record 
		if (LapTimeManager.m_RawTime <= m_RawTime)
		{
			// Handle UI for the best lap time label
			if (LapTimeManager.secondCount <= 9)
			{
				m_SecondLabel.GetComponent<Text>().text = "0" + LapTimeManager.secondCount.ToString() + ".";
			}
			else
			{
				m_SecondLabel.GetComponent<Text>().text = "" + LapTimeManager.secondCount.ToString() + ".";
			}

			if (LapTimeManager.minuteCount <= 9)
			{
				m_MinuteLabel.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount.ToString() + ":";
			}
			else
			{
				m_MinuteLabel.GetComponent<Text>().text = "" + LapTimeManager.minuteCount.ToString() + ":";
			}

			m_MilliSecLabel.GetComponent<Text>().text = "" + LapTimeManager.milliSecCount.ToString();


			// save player's best lap time for future races
			PlayerPrefs.SetInt("minSave", LapTimeManager.minuteCount);
			PlayerPrefs.SetInt("secSave", LapTimeManager.secondCount);
			PlayerPrefs.SetFloat("milliSecSave", LapTimeManager.milliSecCount);
			PlayerPrefs.SetFloat("RawTime", LapTimeManager.m_RawTime);
		}

		// Reset our lap timer once the racer completes the lap
		LapTimeManager.minuteCount = 0;
		LapTimeManager.secondCount = 0;
		LapTimeManager.milliSecCount = 0.0f;
		LapTimeManager.m_RawTime = 0.0f;

	} /* void UpdateLapTimeLabel() */
}