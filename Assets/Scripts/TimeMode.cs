//
// Implementation of TimeMode class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class TimeMode

NAME
	public class TimeMode: Script that enables features available in TimeMode

SYNOPSIS
	public class TimeMode
		-> m_SelectedGameMode: an integer. Holds the integer representation 
			of the game mode.
		-> m_IsTimeModeSelected: a bool. Flag that identifies if the current game
			mode is Time Mode
		-> m_AICar: a GameObject. Holds the AI car.

DESCRIPTION
	The script contains function that disables AI car control

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class TimeMode : MonoBehaviour
{
	private int m_SelectedGameMode;
	public static bool m_IsTimeModeSelected = false;

	[SerializeField] public GameObject m_AICar;


	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function disables the AI car control in Time Mode

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Start()
    {
		// Get the game mode that the racer selected
		m_SelectedGameMode = GameModeSelect.m_GameMode;       

		if (m_SelectedGameMode == 2)
		{
			m_IsTimeModeSelected = true;
			m_AICar.SetActive(false);
		}
    } /* void Start() */
}