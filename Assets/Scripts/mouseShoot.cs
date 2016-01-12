using UnityEngine;
using System.Collections;

public class mouseShoot : MonoBehaviour {
	
		public GameObject Bomb;
	    public GameObject Bomb1;
		public float speed = 5.0f;
		
		// Use this for initialization
		void Start () {
			
		}
		
		void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
			Vector2 direction = target - myPos;
			direction = -direction;
			direction.Normalize();
			Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			GameObject projectile = (GameObject) Instantiate(Bomb, myPos, rotation);
			projectile.GetComponent<Rigidbody>().velocity = direction * speed;
			}

		if (Input.GetKeyDown(KeyCode.B)) {
			Vector2 target = Camera.main.ScreenToWorldPoint( new Vector2(Input.mousePosition.x,  Input.mousePosition.y) );
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
			Vector2 direction = target - myPos;
			direction = -direction;
			direction.Normalize();
			Quaternion rotation = Quaternion.Euler( 0, 0, Mathf.Atan2 ( direction.y, direction.x ) * Mathf.Rad2Deg );
			GameObject projectile = (GameObject) Instantiate(Bomb1, myPos, rotation);
			projectile.GetComponent<Rigidbody>().velocity = direction * speed;
		}
	}
}