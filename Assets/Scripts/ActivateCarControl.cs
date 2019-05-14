//
//	Implementation of ActivateCarControl class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

/*
public class ActivateCarControl

NAME
	public class ActivateCarControl - Script to enable car controls

SYNOPSIS
	public class ActivateCarControl
		-> m_CarControl: GameObject that contains the car control script of the player
		-> m_AICar01: GameObject that contains the AI car

DESCRIPTION
	The script handles the car controls for both the AI and the players.
	Contains functions to enable car controls when the race countdown ends.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class ActivateCarControl : MonoBehaviour
{
	[SerializeField] public GameObject m_CarControl;
	[SerializeField] public GameObject m_AICar01;

	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function enables all the controls for the cars present in the game.
		The function is called when the race starts because the car controls for the 
		AI and the player have been disabled before the race timer starts.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	void Start()
	{
		// Enable player control scripts
		m_CarControl.GetComponent<CarController>().enabled = true;
		m_CarControl.GetComponent<CarUserControl>().enabled = true;

		// Enable AI car control scripts
		m_AICar01.GetComponent<CarAIControl>().enabled = true;
	} /*void Start()*/
}