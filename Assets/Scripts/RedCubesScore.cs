using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubesScore : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		ScoreMode.CurrentScore += 100;
		gameObject.SetActive(false);
	}
}