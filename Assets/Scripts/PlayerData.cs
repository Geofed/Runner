using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {
	public int level = 1; 
	private static PlayerData instance; 

	public static PlayerData Instance () {
		if (instance == null) {
			GameObject container = new GameObject ();
			instance = container.AddComponent<PlayerData>();
		}

		return instance;
	}

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject);
	}
	// Update is called once per frame
	
	void Update () {
	
	}

}
