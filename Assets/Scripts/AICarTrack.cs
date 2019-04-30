using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarTrack : MonoBehaviour
{
	public GameObject Tracker;
	public GameObject[] AITracker = new GameObject[25];
	public int trackerNumber = 0;
	private int numberOfWayPoints = 25;

	// Update is called once per frame
	void Update()
    {
		// move the AI car's position to the next waypoint in the track
		Tracker.transform.position = AITracker[trackerNumber].transform.position;
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
			yield return new WaitForSeconds(0.5f);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	}
}