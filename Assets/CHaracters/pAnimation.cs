using UnityEngine;
using System.Collections;
public class pAnimation : MonoBehaviour {
	public int count;
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim.SetBool("idle", true);
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetBool("idle", false);
			anim.SetBool("walkL", true);
		} else if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetBool("walkL", false);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool("idle", true);
			anim.SetBool("walkR", true);
		} else if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetBool("walkR", false);
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<Animation>().CrossFade ("p_move");
		}
	}


}
