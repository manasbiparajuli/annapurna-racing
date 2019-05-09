﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class ScoreMode : MonoBehaviour
{
	public int selectedGameMode;
	public static int CurrentScore;
	public int InternalScore;

	[SerializeField] public GameObject RaceUI;
	[SerializeField] public GameObject ScoreUI;
	[SerializeField] public GameObject AICar;
	[SerializeField] public GameObject AICarWaypoints;
	[SerializeField] public GameObject PositionDisplayText;
	[SerializeField] public GameObject ScoreLabel;
	[SerializeField] public GameObject ScoreModeObjects;
	[SerializeField] public GameObject PlayerCar;

    // Start is called before the first frame update
    void Start()
    {
		// Reset the score
		CurrentScore = 0;

		// Get the game mode that the racer selected
		selectedGameMode = GameModeSelect.m_GameMode;       

		if (selectedGameMode == 1)
		{
			AICar.SetActive(false);
			RaceUI.SetActive(false);
			PositionDisplayText.SetActive(false);
			AICarWaypoints.SetActive(false);
			ScoreUI.SetActive(true);
			ScoreModeObjects.SetActive(true);


		}
	}

    // Update is called once per frame
    void Update()
    {
		InternalScore = CurrentScore;
		ScoreLabel.GetComponent<Text>().text = "" + InternalScore;
    }
}