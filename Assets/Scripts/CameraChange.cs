using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
	public GameObject NormalCamera;
	public GameObject EagleViewCamera;
	public GameObject DriverViewCamera;

	public int CameraMode = 1;

    // Update is called once per frame
    void Update()
    {
		// Allow the player to change between different camera modes
		if (Input.GetButtonDown("ViewMode"))
		{
			// reset the camera modes to 0 as we only have 3 different viewing modes
			if (CameraMode == 2)
			{
				CameraMode = 0;
			}
			// Increment the camera modes for the player
			else
			{
				CameraMode += 1;
			}

			StartCoroutine(CameraModeChange());
		}
    }

	IEnumerator CameraModeChange()
	{
		yield return new WaitForSeconds(0.01f);

		// Enable only one camera modes while disabling others
		// Also, ensure that we enable a camera mode first before 
		// disallowing the remaining two. This prevents a black screen 
		// for a split frame when we change cameras
		if (CameraMode == 0)
		{
			NormalCamera.SetActive(true);
			EagleViewCamera.SetActive(false);
		}
		else if (CameraMode == 1)
		{
			EagleViewCamera.SetActive(true);
			NormalCamera.SetActive(false);
		}
		else if (CameraMode == 2)
		{
			DriverViewCamera.SetActive(true);
			EagleViewCamera.SetActive(false);
		}
	}
}