using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubesScore : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		ScoreMode.CurrentScore += 50;
		gameObject.SetActive(false);
	}
}