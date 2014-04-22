using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour {
	public Sprite playTexture;
	public Sprite pauseTexture;
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown () {
		bool playing = spriteRenderer.sprite == playTexture;
		spriteRenderer.sprite = (playing) ? pauseTexture : playTexture;
		Time.timeScale = (playing) ? 1 : 0;
	}
}
