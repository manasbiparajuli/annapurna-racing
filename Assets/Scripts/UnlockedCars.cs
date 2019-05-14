//
// Implementation of UnlockedCars class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class UnlockedCars

NAME
	public class UnlockedCars: Script that removes the masked game object layered on
		top of the locked cars

SYNOPSIS
	public class Unlockables
		-> m_GreenCarBoughtPrice: an integer. Holds the price paid for the green car
		-> m_FakeGreenCarObject: a GameObject. Holds the game object that is layered
			on top of the unlockable green car

DESCRIPTION
	The script contains function to remove the layered game object sitting on top of 
	the unlockable car if a purchase has been confirmed

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class UnlockedCars : MonoBehaviour
{
	private int m_GreenCarBoughtPrice;

	[SerializeField] public GameObject m_FakeGreenCarObject;


	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function disables the masked game object sitting on top of 
		the unlockable car

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Start()
	{
		m_GreenCarBoughtPrice = PlayerPrefs.GetInt("GreenCarBought");

		// Uncheck the fake green car object that was layered on top of 
		// the unlocked green car if the racer has purchased the green car
		if (m_GreenCarBoughtPrice == Unlockables.m_GreenCarUnlockPrice)
		{
			m_FakeGreenCarObject.SetActive(false);
		}
	} /* void Start() */
}