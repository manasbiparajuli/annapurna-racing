//
// Implementation of GameModeSelect class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class GameModeSelect

NAME
	public class GameModeSelect: Script to select the different game modes

SYNOPSIS
	public class GameModeSelect
		-> m_GameMode: a static int. Stores the numerical representation of the game modes
		-> m_TrackSelected: a GameObject. Stores the panel for all the tracks available in 
				the game

DESCRIPTION
	The script contains functions to select between three race game modes. Once the 
	player has selected the game mode, the tracks panels are then activated

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class GameModeSelect : MonoBehaviour
{
	// 0 = Default Race, 1= Score, 2= Time
	public static int m_GameMode;

	[SerializeField] public GameObject m_TrackSelected;

	/*
	RaceMode()

	NAME
		RaceMode() - function is called when the player selects the default race mode

	SYNOPSIS
		RaceMode()

	DESCRIPTION
		The function assigns the numerical representation of the default race mode in 
		the integer and then activates the panel that contains the tracks for the game.
		The function is assigned to panels in TrackAndCarSelection Menu.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void RaceMode()
	{
		m_GameMode = 0;
		m_TrackSelected.SetActive(true);
	} /* void TimeMode() */

	/*
	ScoreMode()

	NAME
		ScoreMode() - function is called when the player selects the score race mode

	SYNOPSIS
		ScoreMode()

	DESCRIPTION
		The function assigns the numerical representation of the score race mode in 
		the integer and then activates the panel that contains the tracks for the game.
		The function is assigned to panels in TrackAndCarSelection Menu.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	public void ScoreMode()
	{
		m_GameMode = 1;
		m_TrackSelected.SetActive(true);
	} /* void TimeMode() */

	/*
	TimeMode()

	NAME
		TimeMode() - function is called when the player selects the time race mode

	SYNOPSIS
		TimeMode()

	DESCRIPTION
		The function assigns the numerical representation of the time race mode in 
		the integer and then activates the panel that contains the tracks for the game.
		The function is assigned to panels in TrackAndCarSelection Menu.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	public void TimeMode()
	{
		m_GameMode = 2;
		m_TrackSelected.SetActive(true);
	} /* void TimeMode() */
}