using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public SpriteRenderer usuck;
	private bool isGameOver = false;
	public MeshRenderer howToRestart;
	private System.DateTime dialogStartedTime;
	public float flashTime = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isGameOver) {
			if (Input.GetKeyDown(KeyCode.Space)) {
				Application.LoadLevel(Application.loadedLevelName);
				Time.timeScale = 1;

			}
			TextMesh aTextMesh = howToRestart.GetComponent<TextMesh>();
			System.TimeSpan timeElapsed = (System.DateTime.Now - dialogStartedTime);
			Color textFlashing = Color.Lerp(Color.white,Color.clear,Mathf.PingPong((float)timeElapsed.TotalSeconds,1f));
			aTextMesh.color = textFlashing;
		}
	}

	void OnGameOver () {
		isGameOver = true;
		usuck.enabled = true;
		howToRestart.enabled = true;
		Time.timeScale = 0;
		dialogStartedTime = System.DateTime.Now;

	}
}
