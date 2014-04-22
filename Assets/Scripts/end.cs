using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {
	public LayerMask collisionLayers;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
	void OnTriggerEnter (Collider collider) {
		if ((collisionLayers.value & 1 << collider.gameObject.layer)!=0) {
			SendMessage("OnLevelComplete");
			
			
		}
		
	}
	
}

