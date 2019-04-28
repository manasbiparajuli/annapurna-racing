using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour
{
	[SerializeField] public GameObject greenButton;
	public int cashValue;

	public static int greenCarUnlockPrice = 275;

    // Update is called once per frame
    void Update()
    {
		cashValue = CashDisplay.TotalCash;

		if (cashValue >= greenCarUnlockPrice)
		{
			greenButton.GetComponent<Button>().interactable = true;
		}
    }

	public void GreenCarUnlock()
	{
		greenButton.SetActive(false);
		cashValue -= greenCarUnlockPrice;

		// Player has purchased the green car
		// Update the player preferences for the cash withheld by the player
		CashDisplay.TotalCash -= greenCarUnlockPrice;
		PlayerPrefs.SetInt("SavedCash", CashDisplay.TotalCash);
		PlayerPrefs.SetInt("GreenCarBought", greenCarUnlockPrice);
	}
}
