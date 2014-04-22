using UnityEngine;
using System.Collections;

public class PistonController : MonoBehaviour {
	Vector3 startPos;
	[Range(0, 2)]
	public float pistonSpeed;
	[Range(0, 5)]
	public float movementLength;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = startPos;
		pos.x = pos.x + (movementLength/2f)*Mathf.Sin(Time.time*(pistonSpeed*Mathf.PI*2));
		transform.position = pos;
	}
}
