using UnityEngine;
using System.Collections;

public class LevelDispay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int level = PlayerData.Instance().level;
		GetComponent<TextMesh>().text = "level:" + level;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
