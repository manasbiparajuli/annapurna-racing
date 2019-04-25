using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
	// get the best times achieved by the racer
	// the best lap time had been saved in Player Preferences
	[SerializeField] public int minCount;
	[SerializeField] public int secCount;
	[SerializeField] public float milliSecCount;

	// stores the display label for the best lap time
	[SerializeField] public GameObject minDisplay;
	[SerializeField] public GameObject secDisplay;
	[SerializeField] public GameObject milliSecDisplay;

    // Start is called before the first frame update
    void Start()
    {
		// Load the best lap times from Player Preferences
		minCount = PlayerPrefs.GetInt("minSave");
		secCount = PlayerPrefs.GetInt("secSave");
		milliSecCount = PlayerPrefs.GetFloat("milliSecSave");

		// Update the best lap time display
		if (minCount <= 9)
		{
			minDisplay.GetComponent<Text>().text = "0" + minCount + ":";
		}
		else
		{
			minDisplay.GetComponent<Text>().text = "" + minCount + ":";
		}

		if (secCount <= 9)
		{
			secDisplay.GetComponent<Text>().text = "0" + secCount + ".";
		}
		else
		{
			secDisplay.GetComponent<Text>().text = "" + secCount + ".";
		}
		milliSecDisplay.GetComponent<Text>().text = "" + Mathf.Floor(milliSecCount);
    }
}