using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{
	public GameObject Tracker;
	public GameObject[] AITracker = new GameObject[4];
	public int trackerNumber = 0;
	private int numberOfWayPoints = 4;

	// Update is called once per frame
	void Update()
    {
		//TODO: make the following code more efficient
		if (trackerNumber == 0)
		{
			Tracker.transform.position = AITracker[0].transform.position;
		}

		if (trackerNumber == 1)
		{
			Tracker.transform.position = AITracker[1].transform.position;
		}

		if (trackerNumber == 2)
		{
			Tracker.transform.position = AITracker[2].transform.position;
		}
	}

	private IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("AICar01"))
		{
			this.GetComponent<BoxCollider>().enabled = false;

			trackerNumber += 1;

			if (trackerNumber == numberOfWayPoints)
			{
				trackerNumber = 0;
			}
			yield return new WaitForSeconds(1);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	}
}