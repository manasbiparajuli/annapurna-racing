using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSplashToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(ChangeToMainMenu());
    }

	IEnumerator ChangeToMainMenu()
	{
		yield return new WaitForSeconds(4);

		// Load MainMenu Screen after waiting for 4 seconds
		SceneManager.LoadScene(1);
	}
}
