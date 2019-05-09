//
// Implementation of GreenCubesScore class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class GreenCubesScore

NAME
	public class GreenCubesScore - Script to add points when racer passes through
		green cubes while playing Score Mode

SYNOPSIS
	public class GreenCubesScore
		-> m_GreenCubePoints: an integer. The score that will be added when racers pass 
				through the green cube.

DESCRIPTION
	The script adds points when a racer passes through a green cube in Score Mode

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class GreenCubesScore : MonoBehaviour
{
	// Award points for the green cube
	private readonly int m_GreenCubePoints = 25;

	/*
	void OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the GameObject passes through a collider.
			In this case, the function is called when the racer passes through a green cube in Score Mode.

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the object with the colliders attached to it.

	DESCRIPTION
		The function adds green cube points to the overall score of the player if the racer has passed through the green cube

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
		ScoreMode.CurrentScore += m_GreenCubePoints;

		// Disable the cube as the racer has passed through the object
		gameObject.SetActive(false);

	} /*void OnTriggerEnter(Collider a_Other)*/
}