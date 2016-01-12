using UnityEngine;
using System.Collections;

public class spgMOVE : MonoBehaviour {
	CharacterController Controller; 
	public float speed = 5.0f;
	public float jumpSpeed = 8.0f;
	public float pushPower = 2.0f;
	Vector3 movement = Vector3.zero;
	bool isFacingRight = true;
	
	// Use this for initialization
	void Start () {
		Controller = GetComponent<CharacterController> ();
		
		if (!Controller)
			Controller = gameObject.AddComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.x = Input.GetAxis ("Horizontal") * speed;
		
		if (Controller.isGrounded == false) {
			movement.y += Physics.gravity.y * Time.deltaTime * 100;
		}
		
		if (Input.GetKeyDown ("w") && Controller.isGrounded == true) {
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
			Vector3 tempScale = transform.localScale;
			tempScale.x *= -1;
			transform.localScale = tempScale;
		}

	}
	void OnControllerColliderHit (ControllerColliderHit hit) {
		Rigidbody body = hit.collider.attachedRigidbody;
		
		if (body == null || body.isKinematic) {
			return;
		}
		
		if (hit.moveDirection.y < -0.3f) {
			return;
		}
		
		Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0f, 0f);
		body.velocity = pushDir * pushPower;
	}
	
}