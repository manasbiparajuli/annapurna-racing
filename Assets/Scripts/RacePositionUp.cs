//
// Implementation of RacePositionUp class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
public class RacePositionUp

NAME
	public class RacePositionUp: Script that checks for the position of the racer

SYNOPSIS
	public class RacePositionUp
		-> m_DisplayCurrentPosition: a GameOject. Holds the UI responsible to display the
			current position of the racer

DESCRIPTION
	The script contains function that updates the race position of the player

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class RacePositionUp : MonoBehaviour
{
	[SerializeField] public GameObject m_DisplayCurrentPosition;


	/*
	void OnTriggerExit()

	NAME
		OnTriggerExit() - function is called when the racer passes the the RacePositionDown collider

	SYNOPSIS
		OnTriggerExit()
			-> a_Other: the racer with the colliders attached to it.

	DESCRIPTION
		The function updates the position display of the racer when it detects that the current player
		went ahead of the other racer

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void OnTriggerExit(Collider a_Other)
	{
		// Check if the current object is tagged "CarPosition" as we do not want other objects to
		// trigger when the racer passes through the collider
		if (a_Other.tag.Equals("CarPosition"))
		{
			// Display "First"
			m_DisplayCurrentPosition.GetComponent<Text>().text = "";
		}
	} /* void OnTriggerExit(Collider a_Other) */
}