using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
	[SerializeField] public GameObject LapCompleteTrigger;
	[SerializeField] public GameObject HalfWayTrigger;

	private void OnTriggerEnter(Collider other)
	{
		// Activate the finishing line trigger when the car reaches
		// halfway through the track
		LapCompleteTrigger.SetActive(true);
		HalfWayTrigger.SetActive(false);
	}
}