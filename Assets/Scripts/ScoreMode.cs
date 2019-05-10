//
// Implementation of ScoreMode class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;


/*
public class ScoreMode

NAME
	public class ScoreMode: Script that enables features available in ScoreMode

SYNOPSIS
	public class ScoreMode
		-> m_SelectedGameMode: an integer. Holds the integer representation 
			of the game mode.
		-> m_CurrentScore: a static integer. The score in the current Score Mode
		-> m_InternalScore: an integer. References to the m_CurrentScore which is then 
			used to display in the UI.
		-> m_RaceModeUI:  a GameObject. Holds the UI applicable for Race Mode
		-> m_ScoreModeUI:  a GameObject. Holds the UI applicable for Score Mode
		-> m_AICar: a GameObject. Holds the AI car.
		-> m_AICarWaypoints: a GameObject. Holds the AI waypoints spread across the track
		-> m_PositionDisplayText: a GameObject. Holds the UI that is responsible to display
			the current position of the racer. 
		-> m_ScoreValueLabel: a GameObject. Holds the UI that is responsible to display the 
			racer's score
		-> m_ScoreModeObjects: a GameObject. Holds the components applicable for ScoreMode
		-> m_PlayerCar: a GameObject. Holds the racer's car

DESCRIPTION
	The script contains function that activates the gameobjects required for 
	the score mode.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class ScoreMode : MonoBehaviour
{
	private int m_SelectedGameMode;
	public static int m_CurrentScore;
	private int m_InternalScore;

	[SerializeField] public GameObject m_RaceModeUI;
	[SerializeField] public GameObject m_ScoreModeUI;
	[SerializeField] public GameObject m_AICar;
	[SerializeField] public GameObject m_AICarWaypoints;
	[SerializeField] public GameObject m_PositionDisplayText;
	[SerializeField] public GameObject m_ScoreValueLabel;
	[SerializeField] public GameObject m_ScoreModeObjects;
	[SerializeField] public GameObject m_PlayerCar;

	/*
	Start()

	NAME
		Start() - function is called before the first frame update

	SYNOPSIS
		Start()

	DESCRIPTION
		The function disables the AI car control, Race Mode UI, Race Position UI while 
		enabling game objects necessary for the Score Mode

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Start()
    {
		// Reset the score at the start of the score mode
		m_CurrentScore = 0;

		// Get the game mode that the racer selected
		m_SelectedGameMode = GameModeSelect.m_GameMode;       

		if (m_SelectedGameMode == 1)
		{
			m_AICar.SetActive(false);
			m_RaceModeUI.SetActive(false);
			m_PositionDisplayText.SetActive(false);
			m_AICarWaypoints.SetActive(false);

			m_ScoreModeUI.SetActive(true);
			m_ScoreModeObjects.SetActive(true);
		}
	} /* void Start() */


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates player's score by retrieving the value of 
		static variable containing the player's overall score

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
    {
		m_InternalScore = m_CurrentScore;
		m_ScoreValueLabel.GetComponent<Text>().text = "" + m_InternalScore;
	} /* void Update() */
}