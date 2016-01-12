using UnityEngine;
using System.Collections;

public class bossMove : MonoBehaviour
{

	CharacterController Controller; 
	public float speed = 5.0f;
	Vector3 movement = Vector3.zero;
	public Animator anim;
	public Rigidbody rigid;
	public bool isFacingRight = true;	

	// Use this for initialization
	void Start()
	{
		Controller = GetComponent<CharacterController> ();
		
		if (!Controller)
		{
			Controller = gameObject.AddComponent<CharacterController> ();
		}

		//anim = gameObject.GetComponent<Animator>();
		//rigid = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//anim.SetFloat ("Speed", Mathf.Abs (Input.GetAxis ("Horizontal")));
		//movement.x = Input.GetAxis ("Horizontal") * speed;
		
	
		Controller.Move (movement * Time.deltaTime);
		
		bool shoot = Input.GetButtonDown ("Fire1");
		
		if (shoot) 
		{
			WeaponScript weapon = GetComponent<WeaponScript> ();
			
			if (weapon != null) 
			{
				weapon.Attack (false);
			}
		}



	}
}