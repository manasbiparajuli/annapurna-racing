using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
	[SerializeField] public static int minuteCount;
	[SerializeField] public static int secondCount;
	[SerializeField] public static float milliSecCount;
	[SerializeField] public static string milliDisplay;

	[SerializeField] public GameObject minuteLabel;
	[SerializeField] public GameObject secondLabel;
	[SerializeField] public GameObject milliSecLabel;

	[SerializeField] public static float rawTime;

    // Update is called once per frame
    void Update()
    {
		// take lap time only when the race is ongoing
		// disable recording time when the race completes
		if (!LapComplete.isRaceComplete)
		{
			// Keep track of the millisecond count during the lapcount
			milliSecCount += Time.deltaTime * 10;
			milliDisplay = milliSecCount.ToString("0");
			milliSecLabel.GetComponent<Text>().text = "" + milliDisplay;

			// get the raw time for the race
			rawTime += Time.deltaTime;

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
	}

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
	}
}
