using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	protected Animator animator;
	[Range(0,90)]
	public float turnAngle;
	public float leftBoundry;
	public float rightBoundry;
	private ThirdPersonCharacter character;
	private bool isInvulnerable = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		character = GetComponent<ThirdPersonCharacter>();
	}
	
	// Update is called once per frame
	void Update () {
		bool jump = Input.GetButton("Jump");
		AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (0);			

		if (stateInfo.IsName ("Base Layer.Run")) {
			if (Input.GetButton ("Fire1")) {
				//animator.SetBool ("Jump", true);
			}
		} else {
			//animator.SetBool ("Jump", false);
		}
		float horizontal = Input.GetAxisRaw ("Horizontal");
		Quaternion rotation = transform.rotation;
		if (horizontal == -1 && leftBoundry < transform.position.x) {
			rotation = Quaternion.Euler (0, -turnAngle, 0);
		} else if (horizontal == 1 &&  rightBoundry > transform.position.x) {
			rotation = Quaternion.Euler (0, turnAngle, 0);
		} else {
			rotation = Quaternion.identity;
		}
		transform.rotation = rotation;

		Vector3 position = transform.position;
		position.x = Mathf.Clamp (position.x, leftBoundry, rightBoundry);
		transform.position = position;
		//animator.SetFloat("Speed", float.MaxValue);
		//animator.SetFloat("Direction", 0, 0, Time.deltaTime);	

		character.Move (transform.forward, false, jump, transform.forward);
	
			
	}
	void OnFail () {
		if (!isInvulnerable) {
			Debug.Log ("Onfail");
			StartCoroutine (PlayerReset ());
		}


	}

	IEnumerator PlayerReset () {
		isInvulnerable = true;
		animator.SetBool("OnDie", true);
		Debug.Log ("AboutToSend");
		SendMessage("OnDeath");
		Debug.Log ("Sent");
		yield return new WaitForSeconds (2.533f);
		animator.SetBool ("OnDie", false);
		Vector3 position = transform.position - new Vector3 (0, 0, 6);
		transform.position = position;
		Debug.Log ("PlayerReset");
		yield return new WaitForSeconds (5f);
		isInvulnerable = false;
	}


}
