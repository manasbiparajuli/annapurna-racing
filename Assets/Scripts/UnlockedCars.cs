using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedCars : MonoBehaviour
{
	private int greenCarSelected;

	[SerializeField] public GameObject fakeGreenCarObject;

    // Start is called before the first frame update
    void Start()
    {
		greenCarSelected = PlayerPrefs.GetInt("GreenCarBought");

		// Uncheck the fake green car object that was layered on top of 
		// the unlocked green car if the racer has purchased the green car
		if (greenCarSelected == Unlockables.greenCarUnlockPrice)
		{
			fakeGreenCarObject.SetActive(false);
		}
    }
}