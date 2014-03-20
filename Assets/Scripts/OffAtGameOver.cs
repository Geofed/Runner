using UnityEngine;
using System.Collections;


public class OffAtGameOver : MonoBehaviour {
	public SpriteRenderer[] isOn;
	public int num = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGameOver () {
		isOn [num].enabled = false;
	}
}
