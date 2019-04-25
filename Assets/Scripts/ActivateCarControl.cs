using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ActivateCarControl : MonoBehaviour
{
	public GameObject CarControl;
	public GameObject AICar01;

    // Start is called before the first frame update
    void Start()
    {
		CarControl.GetComponent<CarController>().enabled = true;
		AICar01.GetComponent<CarAIControl>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
