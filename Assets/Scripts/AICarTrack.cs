//
//	Implementation of AICarTrack class
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**/
/*
public class AICarTrack

NAME
	public class AICarTrack - Script to update the AI Car position based on the 
		waypoints spread across the race track

SYNOPSIS
	public class AICarTrack
		-> m_Tracker: a GameObject that contains all the AI waypoints in the track 
		-> m_AITracker: an array of GameObjects that store the AI waypoints
		-> m_TrackerNumber: an integer. The current AI waypoint that the AI car has traversed
		-> m_NumberOfWayPoints: an integer. The total number of AIWaypoints in the race track

DESCRIPTION
	The script contains functions to update the AI position based on the AI waypoints
	setup around the race track.

AUTHOR
	Manasbi Parajuli

DATE
	5/08/2019
*/
public class AICarTrack : MonoBehaviour
{
	[SerializeField] public GameObject m_Tracker;
	[SerializeField] public GameObject[] m_AITracker = new GameObject[34];

	[SerializeField] public int m_TrackerNumber = 0;
	private readonly int m_NumberOfWayPoints = 34;

	/*
	Update()

	NAME
		Update() - function is called once per frame

	SYNOPSIS
		Update()

	DESCRIPTION
		The function updates the race car position for the AI Cars. It uses the set of AI Waypoints 
		stored in the m_Tracker GameObject to move the AI Car to the next one.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/
	void Update()
	{
		// move the AI car's position to the next waypoint in the track
		m_Tracker.transform.position = m_AITracker[m_TrackerNumber].transform.position;
	} /*void Update()*/


	/*
	IEnumerator OnTriggerEnter()

	NAME
		OnTriggerEnter() - function is called when the GameObject passes through a collider.
			In this case, the function is called when the AI Car passes through the waypoints.

	SYNOPSIS
		OnTriggerEnter()
			-> a_Other: the object with the colliders attached to it.

	DESCRIPTION
		The function enables the box collider once the AI Car passes through the waypoint.

	RETURNS
		None

	AUTHOR
		Manasbi Parajuli

	DATE
		5/08/2019
	*/

	private IEnumerator OnTriggerEnter(Collider a_Other)
	{
		// check if the object that passed through the waypoint is an AICar but not the player's car
		if (a_Other.gameObject.tag.Equals("AICar01"))
		{
			this.GetComponent<BoxCollider>().enabled = false;

			// move the AI Car to the next waypoint
			m_TrackerNumber += 1;

			// reset the AI waypoint count after the AI car has passed through all the waypoints
			if (m_TrackerNumber == m_NumberOfWayPoints)
			{
				m_TrackerNumber = 0;
			}

			// wait for few seconds before enabling the box collider on the object
			yield return new WaitForSeconds(0.5f);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	} /*IEnumerator OnTriggerEnter(Collider a_Other)*/
}