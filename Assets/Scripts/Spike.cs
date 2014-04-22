using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {
	public LayerMask collisionLayers;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	void OnCollisionEnter (Collision collision) {
		if ((collisionLayers.value & 1 << collision.gameObject.layer)!=0) {
			SendMessage("OnGameOver");
			
			
		}
		
	}
	
}


