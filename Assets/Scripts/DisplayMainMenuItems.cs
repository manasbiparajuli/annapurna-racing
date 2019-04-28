using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMainMenuItems : MonoBehaviour
{
	[SerializeField] public GameObject largeButton;
	[SerializeField] public GameObject textClick;
	[SerializeField] public GameObject menuItems;

	public void MainMenuItems()
	{
		// Remove the overlay after user clicks on the screen
		// Then, display the menu items
		textClick.SetActive(false);
		menuItems.SetActive(true);
		largeButton.SetActive(false);
	}
}
