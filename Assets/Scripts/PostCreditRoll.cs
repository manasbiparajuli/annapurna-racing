//
// Implementation of PostCreditRoll class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
public class PostCreditRoll

NAME
	public class PostCreditRoll: Script that programmatically animates the 
		text containing the game credits

SYNOPSIS
	public class PostCreditRoll

DESCRIPTION
	The script contains function that allows for the transition of text which 
	holds information for game credits

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class PostCreditRoll : MonoBehaviour
{

	/*
	Start()

	NAME
		Start() - function is called to transition the game credits animation

	SYNOPSIS
		Start()

	DESCRIPTION
		The function starts the coroutine that handles animations for the game credits
		information

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Start()
    {
		StartCoroutine(PostCredit());
    }


	/*
	IEnumerator PostCredit()

	NAME
		PostCredit() - coroutine function that waits for few seconds to display
		the game credits before displaying main menu to the player

	SYNOPSIS
		PostCredit()

	DESCRIPTION
		The function waits for few seconds to display
		the game credits before displaying main menu to the player

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	IEnumerator PostCredit()
	{
		yield return new WaitForSeconds(9);

		// load the main menu scene
		SceneManager.LoadScene(1);

	} /* IEnumerator PostCredit() */
}