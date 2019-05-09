//
// Implementation of CustomizeCar class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class CustomizeCar

NAME
	public class CustomizeCar: Script to activate the car selected by the player in the race menu

SYNOPSIS
	public class CashDisplay
		-> m_RedCarBody: a GameObject. Stores the red color texture needed for a red car
		-> m_BlueCarBody: a GameObject. Stores the red color texture needed for a blue car
		-> m_GreenCarBody: a GameObject. Stores the red color texture needed for a green car
		-> m_CarImport: an integer. Stores the car values in integer form

DESCRIPTION
	The script contains function to activate the correct car model based on the user's 
	car color preferences

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class CustomizeCar : MonoBehaviour
{
	[SerializeField] public GameObject m_RedCarBody;
	[SerializeField] public GameObject m_BlueCarBody;
	[SerializeField] public GameObject m_GreenCarBody;

	// 1 = RED, 2 = Blue, 3= Green
	private int m_CarImport;


	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function gets the car selected by the player by accessing ChooseCar class' 
		static int CarType variable. Then, it activates the selected car's GameObject

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void Start()
    {
		// Get the integer value of the car selected by the player
		m_CarImport = ChooseCar.m_CarType;
		
		// Red Car has been selected
		if (m_CarImport == 1)
		{
			m_RedCarBody.SetActive(true);
		}

		// Blue Car has been selected
		else if (m_CarImport == 2)
		{
			m_BlueCarBody.SetActive(true);
		}

		// Green Car has been selected
		else if (m_CarImport == 3)
		{
			m_GreenCarBody.SetActive(true);
		}
	} /* void Start() */
}