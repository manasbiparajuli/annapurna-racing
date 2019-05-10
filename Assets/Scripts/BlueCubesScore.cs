//
// Implementation of BlueCubesScore class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class BlueCubesScore

NAME
	public class BlueCubesScore - Script to add points when racer passes through
		blue cubes while playing Score Mode

SYNOPSIS
	public class BlueCubesScore
		-> m_BlueCubePoints: an integer. The score that will be added when racers pass 
				through the blue cube.

DESCRIPTION
	The script adds points when a racer passes through a blue cube in Score Mode

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/

public class BlueCubesScore : MonoBehaviour
{
	// Award points for the blue cube
	private readonly int m_BlueCubePoints = 50;


	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the GameObject passes through a collider.
			In this case, the function is called when the racer passes through a blue cube in Score Mode.

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the object with the colliders attached to it.

	DESCRIPTION
		The function adds blue cube points to the overall score of the player if the racer has passed through the blue cube

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	private void OnTriggerEnter(Collider a_Other)
	{
		// Update the overall score of the racer
		ScoreMode.m_CurrentScore += m_BlueCubePoints;

		// Disable the cube as the racer has passed through the object
		gameObject.SetActive(false);
	} /*void OnTriggerEnter(Collider a_Other)*/
}