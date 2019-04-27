﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCar : MonoBehaviour
{
	public static int CarType; // 1 = RED, 2 = Blue
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
}
