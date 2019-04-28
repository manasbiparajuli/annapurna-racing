using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceMode : MonoBehaviour
{
	public int selectedGameMode;

	[SerializeField] public GameObject RaceUI;
	[SerializeField] public GameObject AICar;

    // Start is called before the first frame update
    void Start()
    {
		// Get the game mode that the racer selected
		selectedGameMode = GameModeSelect.GameMode;       

		if (selectedGameMode == 0)
		{
			AICar.SetActive(true);
			RaceUI.SetActive(true);
		}
    }
}