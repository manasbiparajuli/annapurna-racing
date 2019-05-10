//
// Implementation of LoadLapTime class
// 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class LoadLapTime

NAME
	public class LoadLapTime: Script that gets the best lap time from Player Preferences
		and updates the best lap time label

SYNOPSIS
	public class LoadLapTime
		-> m_MinuteCount: an integer. The minute count of the best lap time 
		-> m_SecondCount: an integer. The second count of the best lap time
		-> m_MilliSecCount: a float. The milliseconds count of the best lap time
		-> m_MinDisplay: a GameObject. Holds best lap time's minute label
		-> m_SecDisplay: a GameObject. Holds best lap time's second label
		-> m_MilliSecDisplay: a GameObject. Holds best lap time's millisecond label


DESCRIPTION
	The script contains function that retrieves the best lap time value from the Player Preferences
	and then uses those values to update the best lap time labels in the game menu

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class LoadLapTime : MonoBehaviour
{
	// get the best lap times achieved by the racer and which
	// had been saved in Player Preferences
	[SerializeField] public int m_MinuteCount;
	[SerializeField] public int m_SecondCount;
	[SerializeField] public float m_MilliSecCount;

	// stores the display label for the best lap time
	[SerializeField] public GameObject m_MinDisplay;
	[SerializeField] public GameObject m_SecDisplay;
	[SerializeField] public GameObject m_MilliSecDisplay;

	/*
	Start()

	NAME
		Start() - function is called before the first frame update before the start of the race

	SYNOPSIS
		Start()

	DESCRIPTION
		The function retrieves the best lap time value from the Player Preferences
		and then uses those values to update the best lap time labels in the game menu

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	private void Start()
    {
		// Load the best lap times from Player Preferences
		m_MinuteCount = PlayerPrefs.GetInt("minSave");
		m_SecondCount = PlayerPrefs.GetInt("secSave");
		m_MilliSecCount = PlayerPrefs.GetFloat("milliSecSave");

		// Update the best lap time display
		if (m_MinuteCount <= 9)
		{
			m_MinDisplay.GetComponent<Text>().text = "0" + m_MinuteCount + ":";
		}
		else
		{
			m_MinDisplay.GetComponent<Text>().text = "" + m_MinuteCount + ":";
		}

		if (m_SecondCount <= 9)
		{
			m_SecDisplay.GetComponent<Text>().text = "0" + m_SecondCount + ".";
		}
		else
		{
			m_SecDisplay.GetComponent<Text>().text = "" + m_SecondCount + ".";
		}

		// Display millisecond to one significant figure
		m_MilliSecDisplay.GetComponent<Text>().text = "" + Mathf.FloorToInt(m_MilliSecCount).ToString();

	} /* void Start() */
}