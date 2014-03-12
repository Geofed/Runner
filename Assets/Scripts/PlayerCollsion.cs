using UnityEngine;
using System.Collections;

public class PlayerCollsion : MonoBehaviour {
	public LayerMask collisionLayers;
	protected Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {



	}
	void OnCollisionEnter (Collision collision) {
		if ((collisionLayers.value & 1 << collision.gameObject.layer)!=0) {
			Debug.Log ("onCollisionenter");
			SendMessage("OnFail");

		}

	}

}

