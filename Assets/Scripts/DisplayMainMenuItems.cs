//
// Implementation of DisplayMainMenuItems class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class DisplayMainMenuItems

NAME
	public class DisplayMainMenuItems: Script to display the items in the main menu scene

SYNOPSIS
	public class DisplayMainMenuItems
		-> m_LargeButton: a GameObject. The overlay panel when the player first lands on 
				the main menu screen
		-> m_TextClick: a GameObject. The text object that displays "Click anywhere to begin"
		-> m_MenuItems: a GameObject. The object with all the menu items in the main menu
		-> m_CashDisplay: a GameObject. The object that has text to display in the main menu

DESCRIPTION
	The script contains function to display the current speed of the car in the game menu

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class DisplayMainMenuItems : MonoBehaviour
{
	[SerializeField] public GameObject m_LargeButton;
	[SerializeField] public GameObject m_TextClick;
	[SerializeField] public GameObject m_MenuItems;
	[SerializeField] public GameObject m_CashDisplay;

	/*
	MainMenuItems()

	NAME
		MainMenuItems() - function that activates and deactivates Gameobjects in the main menu

	SYNOPSIS
		MainMenuItems()

	DESCRIPTION
		The function deactivates the screen overlay and then activates game objects that display
		the cash display panel and menu items

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void MainMenuItems()
	{
		// Remove the overlay after user clicks on the screen
		m_LargeButton.SetActive(false);
		m_TextClick.SetActive(false);

		// Then, display the menu items
		m_MenuItems.SetActive(true);
		m_CashDisplay.SetActive(true);

	} /*void MainMenuItems() */
}