using UnityEngine;
using System.Collections;

public class EasePositionOfCamera : MonoBehaviour {
	private float x;
	[Range(0f,0.2f)]
	public float easeAmount;
	void EaseXTo (float x) {
		this.x = x;
	}


	void Start () {
		x = transform.position.x;
	}

	void Update () {
		Vector3 position = transform.position;
		position.x = position.x + ((x - position.x) * easeAmount);
		transform.position = position;
	}
}