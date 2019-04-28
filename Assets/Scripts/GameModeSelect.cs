using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeSelect : MonoBehaviour
{
	// 0 = Default Race, 1= Score, 2= Time
	public static int GameMode;

	[SerializeField] public GameObject TrackSelected;

	public void RaceMode()
	{
		GameMode = 0;
		TrackSelected.SetActive(true);
	}

	public void ScoreMode()
	{
		GameMode = 1;
		TrackSelected.SetActive(true);
	}

	public void TimeMode()
	{
		GameMode = 2;
		TrackSelected.SetActive(true);
	}

}
