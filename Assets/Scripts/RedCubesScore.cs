//
// Implementation of RedCubesScore class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class RedCubesScore

NAME
	public class RedCubesScore - Script to add points when racer passes through
		red cubes while playing Score Mode

SYNOPSIS
	public class RedCubesScore
		-> m_RedCubePoints: an integer. The score that will be added when racers pass 
				through the red cube.

DESCRIPTION
	The script adds points when a racer passes through a red cube in Score Mode

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class RedCubesScore : MonoBehaviour
{
	// Award points for the red cube
	private readonly int m_RedCubePoints = 100;

	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the GameObject passes through a collider.
			In this case, the function is called when the racer passes through a red cube in Score Mode.

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the object with the colliders attached to it.

	DESCRIPTION
		The function adds red cube points to the overall score of the player if the racer has passed through the red cube

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void OnTriggerEnter(Collider other)
	{
		// Update the overall score of the racer
		ScoreMode.m_CurrentScore += m_RedCubePoints;

		// Disable the cube as the racer has passed through the object
		gameObject.SetActive(false);

	} /*void OnTriggerEnter(Collider a_Other)*/
}