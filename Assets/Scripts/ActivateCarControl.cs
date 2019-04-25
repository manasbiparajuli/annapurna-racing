using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ActivateCarControl : MonoBehaviour
{
	public GameObject CarControl;

    // Start is called before the first frame update
    void Start()
    {
		CarControl.GetComponent<CarController>().enabled = true;		        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
