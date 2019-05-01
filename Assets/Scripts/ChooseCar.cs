using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCar : MonoBehaviour
{
	// 1 = RED, 2 = Blue, 3= Green
	public static int CarType; 
	[SerializeField] public GameObject TrackPanel;

	public void RedCar()
	{
		CarType = 1;
		TrackPanel.SetActive(true);
	}

	public void BlueCar()
	{
		CarType = 2;
		TrackPanel.SetActive(true);
	}

	public void GreenCar()
	{
		CarType = 3;
		TrackPanel.SetActive(true);
	}
}
