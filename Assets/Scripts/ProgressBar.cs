//
// Implementation of ProgressBar class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
public class ProgressBar

NAME
	public class ProgressBar: Script that programmatically animates the 
		progress bar and then loads the main menu

SYNOPSIS
	public class ProgressBar
		-> m_LoadingBar: a Slider object. Holds the loading bar object
		-> m_LoadingBarText: a Text object. Holds the text component attached to
			the loading bar
		-> m_LoadingBarIncrement: a float. Holds the value to increment the progress bar
		-> m_LoadingBarTiming: a float. The max value of the loading bar.

DESCRIPTION
	The script contains function that animates the progress bar and then
	loads the main menu after waiting for few seconds

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class ProgressBar : MonoBehaviour
{
	// Loadingbar components
	[SerializeField] public Slider m_LoadingBar;
	[SerializeField] public Text m_LoadingBarText;

	// Slider values
	[SerializeField] public float m_LoadingBarIncrement = 0.2f;
	[SerializeField] public float m_LoadingBarTiming = 1f;

	/*
	Start()

	NAME
		Start() - function is called to transition the progress bar animation

	SYNOPSIS
		Start()

	DESCRIPTION
		The function starts the coroutine that handles animations for the progress bar

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	private void Start()
	{
		StartCoroutine(LoadLoadingBar());

	} /* void Start() */


	/*
	IEnumerator LoadLoadingBar()

	NAME
		LoadLoadingBar() - coroutine function that waits for few seconds 
			before displaying a prompt for the player to press a key. After 
			the key is pressed, the function will load the main menu

	SYNOPSIS
		LoadLoadingBar()
	
	DESCRIPTION
		The function waits for few seconds before displaying a prompt for the 
		player to press a key. After the key is pressed, the function will load 
		the main menu

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	IEnumerator LoadLoadingBar()
	{
		yield return new WaitForSeconds(1);

		// Increment the progress bar by certain amount until 
		// it reaches the value of 1
		while (m_LoadingBar.value != 1f)
		{
			m_LoadingBar.value += m_LoadingBarIncrement;

			yield return new WaitForSeconds(m_LoadingBarTiming);
		}

		// Display prompt for the player to press a key to allow 
		// for the loading of main menu when the progress bar reaches 
		// value of 1
		while (Mathf.Approximately(m_LoadingBar.value, 1f))
		{
			m_LoadingBarText.text = "Press 'Y' to continue";

			// Load the main menu if the player pressed 'Y' on the keyboard
			if (Input.GetKeyDown(KeyCode.Y))
			{
				SceneManager.LoadScene(1);
			}

			yield return null;
		}
	} /* IEnumerator LoadLoadingBar() */
}