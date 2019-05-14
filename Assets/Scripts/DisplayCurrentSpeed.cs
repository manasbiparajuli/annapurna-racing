//
// Implementation of DisplayCurrentSpeed class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

/*
public class DisplayCurrentSpeed

NAME
	public class DisplayCurrentSpeed: Script to display the current speed of the player's car

SYNOPSIS
	public class DisplayCurrentSpeed
		-> m_SpeedPanel: a GameObject. Stores the panel to display Speed
		-> m_PlayerCar: a GameObject. Stores the car of the racer

DESCRIPTION
	The script contains function to display the current speed of the car in the game menu

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class DisplayCurrentSpeed : MonoBehaviour
{
	[SerializeField] public GameObject m_SpeedPanel;
	[SerializeField] public GameObject m_PlayerCar;

	private int m_PlayerCarSpeed;

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the text to display the current speed of the car
		by accessing the CurrentSpeed variable exposed in the Player's CarController class

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Update()
	{
		// The Player's CarController class is only enabled after the race has began
		if (m_PlayerCar.GetComponent<CarController>().enabled)
		{
			// Get the speed of the car from the CarController class attached to the player's car
			// and then round off to an integer
			m_PlayerCarSpeed = Mathf.RoundToInt(m_PlayerCar.GetComponent<CarController>().CurrentSpeed);

			// Cap the player's speed to be always greater than or equal to zero
			if (m_PlayerCarSpeed < 0)
			{
				m_PlayerCarSpeed = 0;
			}

			// Update the text in the speed display panel to display the speed of the car
			m_SpeedPanel.GetComponent<Text>().text = m_PlayerCarSpeed.ToString();
		}

	} /* void Update() */
}