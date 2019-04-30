using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostCreditRoll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(PostCredit());
    }

	// Wait for 10 seconds for the credits to roll before
	// showing the main menu to the player
	IEnumerator PostCredit()
	{
		yield return new WaitForSeconds(6);

		// load the main menu scene
		SceneManager.LoadScene(1);
	}
}