using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {
	public SpriteRenderer[] hearts;
	public GameObject player;
	public int lives;
	// Use this for initialization
	void Start () {
		lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnDeath () {
		Debug.Log ("OnDeath");
		lives = lives - 1;
		if (lives >= 0) {
			hearts [lives].enabled = false;
		} else {
			SendMessage("OnGameOver");
		}

	}

}
