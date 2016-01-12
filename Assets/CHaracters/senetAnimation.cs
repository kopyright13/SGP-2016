using UnityEngine;
using System.Collections;
public class senetAnimation : MonoBehaviour {
	public int count;
	public Animator anim;
	// Use this for initialization
	void Start () {
		//animation.Play ("s_idles");

		anim.SetBool("move", false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
						//animation.Stop ();
						//print ("move left");
						//animation.CrossFade ("s_move_left");
						anim.SetBool("swap", true);
						anim.SetBool("leftmove", true);
						if (Input.GetKeyDown (KeyCode.Space)) {
								//animation.CrossFade ("s_attack");
						}
				} else if (Input.GetKeyUp (KeyCode.A)) {
						//animation.CrossFade ("s_idle_l");
						//print ("Left Up");
						anim.SetBool("leftmove", false);
						//anim.SetBool("move", false);
				} else if (Input.GetKeyDown (KeyCode.D)) {
						//animation.Stop ();
						//print ("move right");
						//animation.CrossFade ("s_move");
						anim.SetBool("swap", false);
						anim.SetBool ("move",true);
						if (Input.GetKeyDown (KeyCode.Space)) {
								//animation.CrossFade ("s_attack");
								//anim.SetBool ("attack",true);
						}
				} else if (Input.GetKeyUp (KeyCode.D)) {
					anim.SetBool("swap", false);
					//animation.CrossFade ("s_idles");
					//print ("Right Up");
					anim.SetBool("move", false);
				} else if (Input.GetKeyDown (KeyCode.Space)) {
							//animation.CrossFade ("s_attack");
							anim.SetBool ("attack",true);
				}else if (Input.GetKeyUp (KeyCode.Space)) {
							//animation.CrossFade ("s_idles");
							anim.SetBool ("attack",false);
				}
						
	}
}
