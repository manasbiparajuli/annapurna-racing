using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeSelect : MonoBehaviour
{
	// 0 = Default Race, 1= Score, 2= Time
	public static int GameMode; 

	public void ScoreMode()
	{
		GameMode = 1;
	}

	public void TimeMode()
	{
		GameMode = 2;
	}

}
