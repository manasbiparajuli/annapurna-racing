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

	[SerializeField] public GameObject lapTimeLabel;

	private void OnTriggerEnter(Collider other)
	{
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
			minuteLabel.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
		}
		else
		{
			minuteLabel.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ".";
		}

		milliSecLabel.GetComponent<Text>().text = "" + LapTimeManager.milliSecCount;


		LapTimeManager.minuteCount = 0;
		LapTimeManager.secondCount = 0;
		LapTimeManager.milliSecCount = 0;

		HalfwayTrigger.SetActive(true);
		LapCompleteTrigger.SetActive(false);
	}
}
