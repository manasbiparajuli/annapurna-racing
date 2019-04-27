using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashDisplay : MonoBehaviour
{
	public int CashValue;
	public static int TotalCash;

	public GameObject CashPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		CashValue = TotalCash;

		CashPanel.GetComponent<Text>().text = "Cash $" + CashValue;
    }
}