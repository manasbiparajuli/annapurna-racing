using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMode : MonoBehaviour
{
	public int selectedGameMode;
	public static bool isTimeModeSelected = false;

	[SerializeField] public GameObject AICar;

    // Start is called before the first frame update
    void Start()
    {
		// Get the game mode that the racer selected
		selectedGameMode = GameModeSelect.GameMode;       

		if (selectedGameMode == 2)
		{
			isTimeModeSelected = true;
			AICar.SetActive(false);
		}
    }
}