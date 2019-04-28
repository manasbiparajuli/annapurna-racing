using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceComplete : MonoBehaviour
{
	[SerializeField] public GameObject playerCar;
	[SerializeField] public GameObject AICar;
	[SerializeField] public GameObject raceCompleteCamera;
	[SerializeField] public GameObject cameraViewModes;
	[SerializeField] public GameObject levelMusic;
	[SerializeField] public GameObject completeTrigger;

	[SerializeField] public AudioSource raceCompleteMusic;

	private void OnTriggerEnter(Collider other)
	{
		if (TimeMode.isTimeModeSelected)
		{
			// Race Time Mode selected
		}

		else
		{
			// Disable the box collider for the race complete trigger
			this.GetComponent<BoxCollider>().enabled = false;

			// Disable car controllers after the race is completed
			playerCar.SetActive(false);
			AICar.SetActive(false);
			completeTrigger.SetActive(false);

			// Stop AI cars when race ends
			CarController.m_Topspeed = 0.0f;

			playerCar.GetComponent<CarController>().enabled = false;
			AICar.GetComponent<CarController>().enabled = false;
			playerCar.GetComponent<CarUserControl>().enabled = false;
			AICar.GetComponent<CarAIControl>().enabled = false;

			playerCar.SetActive(true);
			AICar.SetActive(false);

			playerCar.GetComponent<CarAudio>().StopSound();
			playerCar.GetComponent<CarAudio>().enabled = false;
			AICar.GetComponent<CarAudio>().StopSound();
			AICar.GetComponent<CarAudio>().enabled = false;

			raceCompleteCamera.SetActive(true);
			levelMusic.SetActive(false);
			cameraViewModes.SetActive(false);

			raceCompleteMusic.Play();
		}
	}
}