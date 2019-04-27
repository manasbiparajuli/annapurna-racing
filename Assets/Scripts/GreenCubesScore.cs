using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubesScore : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		ScoreMode.CurrentScore += 25;
		gameObject.SetActive(false);
	}
}