//
// Implementation of CameraChange
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class CameraChange

NAME
	public class CameraChange - Script to switch between different camera modes

SYNOPSIS
	public class CameraChange
		-> m_NormalCamera: a GameObject. The normal camera view for the race
		-> m_EagleViewCamera: a GameObject. The eagle view of the camera. The camera is placed further
				than the normal camera
		-> m_DriverViewCamera: a GameObject. The camera from the driver's seat
		-> m_CameraMode: an integer. The value for the camera mode to allow for switching between cameras
				when the player clicks on the camera change key

DESCRIPTION
	The script contains functions that switches between different camera modes in the game

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class CameraChange : MonoBehaviour
{
	[SerializeField] public GameObject m_NormalCamera;
	[SerializeField] public GameObject m_EagleViewCamera;
	[SerializeField] public GameObject m_DriverViewCamera;

	private int m_CameraMode = 1;

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function switches between the camera modes in the race

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	void Update()
    {
		// Allow the player to change between different camera modes
		if (Input.GetButtonDown("ViewMode"))
		{
			// reset the camera modes to 0 as we only have 3 different viewing modes
			if (m_CameraMode == 2)
			{
				m_CameraMode = 0;
			}
			// Increment the camera modes for the player
			else
			{
				m_CameraMode += 1;
			}

			// Allow for some time to pass before changing the camera to allow for smooth transition
			StartCoroutine(CameraModeChange());
		}
	} /*void Update()*/


	/*
	IEnumerator CameraModeChange()

	NAME
		CameraModeChange() - function is called when the player presses Camera Change key to switch 
			between different camera modes

	SYNOPSIS
		CameramodeChange()

	DESCRIPTION
		The function waits for few microseconds before switching between camera modes. 
		The function ensures that only one camera mode is present in the game view. 
		The other camera modes are disabled.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	IEnumerator CameraModeChange()
	{
		yield return new WaitForSeconds(0.01f);

		// Enable only one camera modes while disabling others
		// Also, ensure that we enable a camera mode first before 
		// disallowing the remaining two. This prevents a black screen 
		// for a split frame when we change cameras
		if (m_CameraMode == 0)
		{
			m_NormalCamera.SetActive(true);
			m_EagleViewCamera.SetActive(false);
		}
		else if (m_CameraMode == 1)
		{
			m_EagleViewCamera.SetActive(true);
			m_NormalCamera.SetActive(false);
		}
		else if (m_CameraMode == 2)
		{
			m_DriverViewCamera.SetActive(true);
			m_EagleViewCamera.SetActive(false);
		}
	} /*IEnumerator CameraModeChange()*/
}