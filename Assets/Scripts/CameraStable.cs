//
// Implementation of CameraStable class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class CameraStable

NAME
	public class CameraStable - Script to keep the camera stable even after it crashes

SYNOPSIS
	public class CameraStable
		-> m_RaceCar: a GameObject. The player's car
		-> m_RaceCarX: float. The euler angle of the race car for X coordinates
		-> m_RaceCarY: float. The euler angle of the race car for Y coordinates
		-> m_RaceCarZ: float. The euler angle of the race car for Z coordinates

DESCRIPTION
	The script contains functions that stabilizes the race car throughout the race by
	ensuring the euler angles are constant in the Y direction

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class CameraStable : MonoBehaviour
{
	[SerializeField] public GameObject m_RaceCar;

	private float m_RaceCarX;
	private float m_RaceCarY;
	private float m_RaceCarZ;

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the euler angles of the racer's cars

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Update()
	{
		m_RaceCarX = m_RaceCar.transform.eulerAngles.x;
		m_RaceCarY = m_RaceCar.transform.eulerAngles.y;
		m_RaceCarZ = m_RaceCar.transform.eulerAngles.z;

		// keep camera axis fixed on y-axis so that camera follows the car when it tilts
		transform.eulerAngles = new Vector3(m_RaceCarX - m_RaceCarX, m_RaceCarY, m_RaceCarZ - m_RaceCarZ);

	} /*void Update()*/
}