//
// Implementation of SkyboxRotation class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class SkyboxRotation

NAME
	public class SkyboxRotation: Script that rotates the skybox

SYNOPSIS
	public class SkyboxRotation
		-> m_RotationSpeed: a float. The rotation speed of the skybox

DESCRIPTION
	The script contains function that updates the rotation of the skybox
	in the background by adding rotation speed to rotation components

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class SkyboxRotation : MonoBehaviour
{
	private readonly float m_RotationSpeed = 5.0f;


	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the rotation value of the skybox in the background

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Update()
    {
		//Sets the float value of "_Rotation", adjust it by Time.time and a multiplier.
		RenderSettings.skybox.SetFloat("_Rotation", m_RotationSpeed * Time.time);
	} /* void Update() */
}