using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {
	public SpriteRenderer YOUWIN;
	public Animator cameraAnimator;
	public GameObject targetCamera;
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
		targetCamera.SendMessage("EaseXTo", transform.position.x);
		yield return new WaitForSeconds(waitTime*Time.timeScale);
		Debug.Log("Yeild");
		Time.timeScale = 1f;
		PlayerData.Instance().level++;
		Debug.Log("LoadLevel");
		Application.LoadLevel(Application.loadedLevelName);
	}
}
