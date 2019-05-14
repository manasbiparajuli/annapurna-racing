//
// Implementation of RaceMode class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
public class RaceMode

NAME
	public class RaceMode: Script that enables features available in RaceMode

SYNOPSIS
	public class RaceMode
		-> m_SelectedGameMode: an integer. Holds the integer representation 
			of the game mode.
		-> m_RaceModeUI:  a GameObject. Holds the UI applicable for Race Mode
		-> m_AICar: a GameObject. Holds the AI car.

DESCRIPTION
	The script contains function that activates the gameobjects required for 
	the race mode. The AI race car and Race UI are enabled.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class RaceMode : MonoBehaviour
{
	private int m_SelectedGameMode;

	[SerializeField] public GameObject m_RaceModeUI;
	[SerializeField] public GameObject m_AICar;


	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function enables the AI car control and Race Mode UI if the 
		game is in Race Mode

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

		if (m_SelectedGameMode == 0)
		{
			// Activate the AI Car controls and race mode UI
			m_AICar.SetActive(true);
			m_RaceModeUI.SetActive(true);
		}
	} /* void Start() */
}