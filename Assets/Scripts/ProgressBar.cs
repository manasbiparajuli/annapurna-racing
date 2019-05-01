using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
	AsyncOperation a0;
	public Slider loadingBar;
	public Text loadingBarText;

	public bool isLoadingBar = false;
	public float loadingBarIncrement = 0.2f;
	public float loadingBarTiming = 1f;

	// Start is called before the first frame update
    void Start()
    {
		StartCoroutine(LoadLoadingBar());
    }

	IEnumerator LoadLoadingBar()
	{
		yield return new WaitForSeconds(1);

		while (loadingBar.value != 1f)
		{
			loadingBar.value += loadingBarIncrement;

			yield return new WaitForSeconds(loadingBarTiming);
		}

		while (Mathf.Approximately(loadingBar.value, 1f))
		{
			loadingBarText.text = "Press 'Y' to continue";

			if (Input.GetKeyDown(KeyCode.Y))
			{
				SceneManager.LoadScene(1);
			}

			yield return null;
		}
	}
}
