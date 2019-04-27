﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeCar : MonoBehaviour
{
	public GameObject RedCarBody;
	public GameObject BlueCarBody;

	public int CarImport; // 1 = RED, 2 = Blue

	// Start is called before the first frame update
	void Start()
    {
		// Get the integer value of the car selected by the player
		CarImport = ChooseCar.CarType;
		
		// Red Car has been selected
		if (CarImport == 1)
		{
			RedCarBody.SetActive(true);
		}

		// Blue Car has been selected
		else if (CarImport == 2)
		{
			BlueCarBody.SetActive(true);
		}
    }
}