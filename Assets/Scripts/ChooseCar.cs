//
// Implementation of ChooseCar class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class ChooseCar

NAME
	public class ChooseCar: Script to activate the selected car in the TrackAndCarSelection menu.
		The game mode panel will become active only after the car is selected by the player

SYNOPSIS
	public class ChooseCar
		-> m_CarType: static integer. Stores the three different types of car models present in the game
		-> m_TrackPanel: a GameObject. Stores the track panel that contains the tracks in the game.

DESCRIPTION
	The script contains function to choose the car based on player's preferences and then activate the track panel

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class ChooseCar : MonoBehaviour
{
	// 1 = RED, 2 = Blue, 3= Green
	public static int m_CarType;

	[SerializeField] public GameObject m_TrackPanel;

	/*
	RedCar()

	NAME
		RedCar() - function is called when the player selects the red car in the car selection scene

	SYNOPSIS
		RedCar()

	DESCRIPTION
		The function updates the integer representation of the red car and stores in the static int variable m_CarType.
		Then, it activates the track panel where the player now has the option to choose the track

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	public void RedCar()
	{
		m_CarType = 1;
		m_TrackPanel.SetActive(true);
	} /*void RedCar() */


	/*
	BlueCar()

	NAME
		BlueCar() - function is called when the player selects the blue car in the car selection scene

	SYNOPSIS
		BlueCar()

	DESCRIPTION
		The function updates the integer representation of the blue car and stores in the static int variable m_CarType.
		Then, it activates the track panel where the player now has the option to choose the track

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void BlueCar()
	{
		m_CarType = 2;
		m_TrackPanel.SetActive(true);
	} /* void BlueCar() */


	/*
	GreenCar()

	NAME
		GreenCar() - function is called when the player selects the red car in the car selection scene

	SYNOPSIS
		GreenCar()

	DESCRIPTION
		The function updates the integer representation of the green car and stores in the static int variable m_CarType.
		Then, it activates the track panel where the player now has the option to choose the track

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void GreenCar()
	{
		m_CarType = 3;
		m_TrackPanel.SetActive(true);
	} /* void GreenCar() */
}