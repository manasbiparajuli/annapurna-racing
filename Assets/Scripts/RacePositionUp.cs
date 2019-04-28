using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacePositionUp : MonoBehaviour
{
	public GameObject displayPosition;

	private void OnTriggerExit(Collider other)
	{
		if (other.tag.Equals("CarPosition"))
		{
			displayPosition.GetComponent<Text>().text = "FIRST";
		}
	}
}