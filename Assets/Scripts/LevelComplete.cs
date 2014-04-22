using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {
	public SpriteRenderer YOUWIN;
	public Animator cameraAnimator;
	[Range(0f, 6f)]
	public float waitTime; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator OnLevelComplete()
	{
		Time.timeScale = 0.1f;
		YOUWIN.enabled = true;
		cameraAnimator.SetTrigger("Finish line Crossed");
		yield return new WaitForSeconds(waitTime*Time.timeScale);
		Time.timeScale = 1f;
		GameObject.FindObjectOfType<PlayerData>().level++;
		Application.LoadLevel(Application.loadedLevelName);
	}
}
