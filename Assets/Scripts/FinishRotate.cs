//
// Implementation of FinishRotate class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class FinishRotate

NAME
	public class FinishRotate: Script to rotate the camera around the player's car 
		after the race completes

SYNOPSIS
	public class FinishRotate

DESCRIPTION
	The script contains function to rotate the camera around the player's car

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class FinishRotate : MonoBehaviour
{

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the rotation of the camera by moving around the player's car 
		once the race ends.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Update()
    {
		transform.Rotate(0, 1, 0, Space.World);        
    } /* void Update() */
}