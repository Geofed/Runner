using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Res () {
		GameObject[] reserectPoints = GameObject.FindGameObjectsWithTag ("Respawn");
		GameObject closestResPoint = null;
		float closest = float.MaxValue;
		foreach (GameObject reserectPoint in reserectPoints) {
			if (transform.position.z > reserectPoint.transform.position.z) {
				float currentDistance = reserectPoint.transform.position.z - transform.position.z;
				if (closest > currentDistance) {
					closest = currentDistance;
					closestResPoint = reserectPoint;
				}
			}

		
		}
		if (closestResPoint == null) {
			throw new UnityException ("No Spawn Point Found.");
		}

		transform.position = closestResPoint.transform.position;
	}

}
