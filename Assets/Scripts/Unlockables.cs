//
// Implementation of Unlockables class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
public class Unlockables

NAME
	public class Unlockables: Script that allows for unlockable cars to be bought 
		if the player has enough cash

SYNOPSIS
	public class Unlockables
		-> m_FakeGreenCarObject: a GameObject. Holds the game object that is 
			layered above the unlocked car to discourage user clicks if the 
			racer does not have enough cash to buy it
		-> m_CashOwnedByPlayer: an integer. Retrieves the amount owned by the player
		-> m_GreenCarUnlockPrice: a static integer. Holds the price of the green car

DESCRIPTION
	The script contains function that checks if a player has enough cash to buy the 
	unlocked car. If the player has cash, then the car can be clicked. After the car 
	is bought, then the car price is deducted from the player's profile

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class Unlockables : MonoBehaviour
{
	// The Uninteractable game object masking the green car
	[SerializeField] public GameObject m_FakeGreenCarObject;

	// Retrieves the cash owned by the player
	private int m_CashOwnedByPlayer;

	// Unlock price of the green car
	public static int m_GreenCarUnlockPrice = 275;


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function removes the masked game object sitting on top of the 
		unlocked car to allow for purchase if the player has enough money to buy it

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
	{
		m_CashOwnedByPlayer = CashDisplay.m_TotalCash;

		// Check if the player is eligible to buy the unlocked car
		if (m_CashOwnedByPlayer >= m_GreenCarUnlockPrice)
		{
			m_FakeGreenCarObject.GetComponent<Button>().interactable = true;
		}
	} /* void Update() */


	/*
	GreenCarUnlock()

	NAME
		GreenCarUnlock() - function is called when the player unlocks the green car

	SYNOPSIS
		GreenCarUnlock()

	DESCRIPTION
		The function updates the cash owned by the player if a successful purchase of the
		unlocked green car has been made

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void GreenCarUnlock()
	{
		m_FakeGreenCarObject.SetActive(false);
		m_CashOwnedByPlayer -= m_GreenCarUnlockPrice;

		// Player has purchased the green car
		// Update the Player Preferences for the cash withheld by the player
		CashDisplay.m_TotalCash -= m_GreenCarUnlockPrice;
		PlayerPrefs.SetInt("SavedCash", CashDisplay.m_TotalCash);
		PlayerPrefs.SetInt("GreenCarBought", m_GreenCarUnlockPrice);
	} /* void GreenCarUnlock() */
}