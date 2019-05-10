//
// Implementation of LapTimeManager class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class LapTimeManager

NAME
	public class LapTimeManager: Script to update the lap time as race progresses

SYNOPSIS
	public class LapTimeManager
		-> m_MinuteLabel: a GameObject. The label to display minute
		-> m_SecondLabel: a GameObject. The label to display second
		-> m_MilliSecLabel: a GameObject. The label to display millisecond
		-> m_MinuteCount: a static integer. The minute count of the race
		-> m_SecondCount: a static integer. The second count of the race
		-> m_MilliSecCount: a static float. The milliseconds count of the race
		-> m_MilliDisplay: a static string. The text to display in the millisecond label
		-> m_RawTime: a static float. The total time passed in seconds to complete the last frame

DESCRIPTION
	The script contains function to keep track of the time as the race has progressed and updates
	the lap time label accordingly.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/

public class LapTimeManager : MonoBehaviour
{
	// labels for the lap timer
	[SerializeField] public GameObject minuteLabel;
	[SerializeField] public GameObject secondLabel;
	[SerializeField] public GameObject milliSecLabel;

	// the lap time counter
	[SerializeField] public static int minuteCount;
	[SerializeField] public static int secondCount;
	[SerializeField] public static float milliSecCount;
	[SerializeField] public static string milliDisplay;

	// the total time passed in seconds to complete the last frame
	[SerializeField] public static float m_RawTime;


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function keeps track of the time that has passed since the race started and
		updates the milliseconds, seconds and minute accordingly

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
    {
		// take lap time only when the race is ongoing
		// disable recording time when the race completes
		if (!LapComplete.m_IsRaceComplete)
		{
			// Keep track of the millisecond count during the lapcount
			milliSecCount += Time.deltaTime * 10;

			// update the millisecond display
			milliDisplay = milliSecCount.ToString("0");
			milliSecLabel.GetComponent<Text>().text = "" + milliDisplay;

			// get the raw time for the race
			m_RawTime += Time.deltaTime;

			// Add a second once 10 milliseconds pass during the lap time
			if (milliSecCount >= 10)
			{
				milliSecCount = 0;
				secondCount += 1;
			}

			// Add a minute once 60 seconds pass during the lap time
			if (secondCount >= 60)
			{
				secondCount = 0;
				minuteCount += 1;
			}

			// Update our lap time labels after the game has started
			UpdateLapLabels();
		}
	} /* void Update()*/


	/*
	UpdateLapLabels()

	NAME
		UpdateLapLabels() - function is called during every frame and when the race 
			still progresses

	SYNOPSIS
		UpdateLapLabels()

	DESCRIPTION
		The function udpates the lap time label as the race progresses

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void UpdateLapLabels()
	{
		// we add a '0' in our second sring to represent second in two precision places
		if (secondCount <= 9)
		{
			secondLabel.GetComponent<Text>().text = "0" + secondCount + ".";
		}
		// no need to put '0' in front of our second representation
		else
		{
			secondLabel.GetComponent<Text>().text = "" + secondCount + ".";
		}

		// Similarly, change text for minute labels
		if (minuteCount <= 9)
		{
			minuteLabel.GetComponent<Text>().text = "0" + minuteCount + ":";
		}
		else
		{
			minuteLabel.GetComponent<Text>().text = "" + minuteCount + ":";
		}
	} /*void UpdateLapLabels()*/
}