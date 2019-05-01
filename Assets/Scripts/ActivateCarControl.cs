using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ActivateCarControl : MonoBehaviour
{
	[SerializeField] public GameObject CarControl;
	[SerializeField] public GameObject AICar01;

    // Start is called before the first frame update
    void Start()
    {
		CarControl.GetComponent<CarController>().enabled = true;
		CarControl.GetComponent<CarUserControl>().enabled = true;
		AICar01.GetComponent<CarAIControl>().enabled = true;
    }
}
