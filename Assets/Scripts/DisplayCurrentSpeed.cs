using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class DisplayCurrentSpeed : MonoBehaviour
{
	[SerializeField] public GameObject SpeedPanel;
	[SerializeField] public GameObject PlayerCar;

	private int PlayerCarSpeed;

    // Update is called once per frame
    void Update()
    {
		if (PlayerCar.GetComponent<CarController>().enabled)
		{
			PlayerCarSpeed = Mathf.RoundToInt(PlayerCar.GetComponent<CarController>().CurrentSpeed);

			if (PlayerCarSpeed < 0)
			{
				PlayerCarSpeed = 0;
			}

			SpeedPanel.GetComponent<Text>().text = PlayerCarSpeed.ToString();
		}
	}
}