using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleLocomotion : MonoBehaviour
{
	
	// Here we create an empty NavMeshAgent variable
	private NavMeshAgent _nav;

	// A public field to refernce a waypoint position
	public Transform waypoint;

	private void Awake()
	{
		_nav = GetComponent<NavMeshAgent>();

		// In awake we set our Actor's destination to be our waypoint's postion
		_nav.destination = waypoint.position;
	}
}
