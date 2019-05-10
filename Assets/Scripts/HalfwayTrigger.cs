//
// Implementation of HalfwayTrigger class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class HalfwayTrigger

NAME
	public class HalfwayTrigger: Script to activate the finish line game object

SYNOPSIS
	public class HalfwayTrigger
		-> m_LapCompleteTrigger: a GameObject. Contains the finish line game object
		-> m_HalfwayTrigger: a GameObject. Contains the halfway line game object

DESCRIPTION
	The script contains function to activate the finish line gameobject and disable the halfway 
	track game object when the racer passes through the halfway track. 

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class HalfwayTrigger : MonoBehaviour
{
	[SerializeField] public GameObject m_LapCompleteTrigger;
	[SerializeField] public GameObject m_HalfWayTrigger;


	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the player passes through the halfway line trigger

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the halfway line object with the colliders attached to it.

	DESCRIPTION
		The function enables activates the finishing line game object while disabling the halfway line 
		game object once the player passes through the halfway object collider

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void OnTriggerEnter(Collider a_Other)
	{
		// Activate the finishing line trigger when the car reaches
		// halfway through the track
		m_LapCompleteTrigger.SetActive(true);
		m_HalfWayTrigger.SetActive(false);
	} /* void OnTriggerEnter(Collider a_Other) */
}