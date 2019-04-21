using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
	[SerializeField] public GameObject raceCar;

	public float raceCarX;
	public float raceCarY;
	public float raceCarZ;

    // Update is called once per frame
    void Update()
    {
		raceCarX = raceCar.transform.eulerAngles.x;
		raceCarY = raceCar.transform.eulerAngles.y;
		raceCarZ = raceCar.transform.eulerAngles.z;

		// keep camera axis fixed on y-axis so that camera follows the car when it tilts
		transform.eulerAngles = new Vector3(raceCarX - raceCarX, raceCarY, raceCarZ - raceCarZ);
    }
}
