using UnityEngine;
using System.Collections;

public class PlayerCollsion : MonoBehaviour {
	public LayerMask collisionLayers;
	protected Animator animator;
	[Range(-1, 1)]
	public float forwardCollisionThreshold;
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
			float forwardCollision = Vector3.Dot(Vector3.back, collision.contacts[0].normal);
			Debug.Log(forwardCollision);
			if (forwardCollision > forwardCollisionThreshold) {
				SendMessage("OnFail");
			}


		}

	}

}

