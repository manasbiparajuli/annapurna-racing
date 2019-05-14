//
// Implementation of CashDisplay class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class CashDisplay

NAME
	public class CashDisplay - Script to display the cash earned by the player
		in the main menu after they complete races 

SYNOPSIS
	public class CashDisplay
		-> m_CashPanel: a GameObject. Stores the panel to display the cash owned by the player
		-> m_CashValue: an integer. The initial cash value at the beginning of the game
		-> m_TotalCash: a static integer. The total cash owned by the player

DESCRIPTION
	The script contains functions that retrieves the cash owned by the player and which is stored in 
	the Player Preferences. Then, the cash owned is displayed in the main screen by updating the text
	component in the Cash Display panel

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class CashDisplay : MonoBehaviour
{
	[SerializeField] public GameObject m_CashPanel;

	private int m_CashValue;

	public static int m_TotalCash;

	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function gets the cash owned by the player by deserializing the amount
		stored in the Player Preferences.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Start()
	{
		m_TotalCash = PlayerPrefs.GetInt("SavedCash");
	} /* void Start() */


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the cash amount owned by the player and displays it
		in the Cash Display panel 

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	void Update()
	{
		// Get the cash saved in the Player Preferences
		m_CashValue = m_TotalCash;

		// Get the text component of our Cash Display Panel and update the text with the 
		// cash owned by the player
		m_CashPanel.GetComponent<Text>().text = "Cash $" + m_CashValue;

	} /* void Update() */
}