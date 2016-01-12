using UnityEngine;
using System.Collections;

public class pMove : MonoBehaviour {
		CharacterController Controller; 
		public float speed = 5.0f;
		public float jumpSpeed = 8.0f;
		public float pushPower = 2.0f;
		Vector3 movement = Vector3.zero;
		Animator anim;
		bool isFacingRight = true;
		
		// Use this for initialization
		void Start () {
			Controller = GetComponent<CharacterController> ();
			
			if (!Controller)
				Controller = gameObject.AddComponent<CharacterController> ();
				anim = gameObject.GetComponent<Animator>();
		}
		
		// Update is called once per frame
		void Update () {
			anim.SetFloat ("Speed", Mathf.Abs (Input.GetAxis ("Horizontal")));
			movement.x = Input.GetAxis ("Horizontal") * speed;
			
			if (Controller.isGrounded == false) {
				movement.y += Physics.gravity.y * Time.deltaTime * 30;
			}
			
			if (Input.GetButton ("Jump") && Controller.isGrounded == true) {
				movement.y = jumpSpeed;
			}
			
			Controller.Move (movement * Time.deltaTime);
			
			bool wasFacingRight = isFacingRight;
			
			if (Input.GetKeyDown (KeyCode.A))
			{
				isFacingRight = false;
			}
			else if(Input.GetKeyDown (KeyCode.D))
			{
				isFacingRight = true;
			}
			
			if(isFacingRight != wasFacingRight)
			{
				anim.StopPlayback();
				Vector3 tempScale = transform.localScale;
				tempScale.x *= -1;
				transform.localScale = tempScale;
			}

		}
	}

