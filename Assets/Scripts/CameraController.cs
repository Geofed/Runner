using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public Vector3 relativePosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.z = player.transform.position.z + relativePosition.z;
		transform.position = position;


	}
}
