using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMainMenuItems : MonoBehaviour
{
	[SerializeField] public GameObject largeButton;
	[SerializeField] public GameObject textClick;
	[SerializeField] public GameObject menuItems;
	[SerializeField] public GameObject cashDisplay;

	public void MainMenuItems()
	{
		// Remove the overlay after user clicks on the screen
		// Then, display the menu items
		largeButton.SetActive(false);
		textClick.SetActive(false);

		menuItems.SetActive(true);
		cashDisplay.SetActive(true);
	}
}
