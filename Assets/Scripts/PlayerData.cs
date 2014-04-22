using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {
	public int level = 1; 

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
