using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public GameObject bullet;
	
	public float shootingInterval = 0.5f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("Shoot", 0, shootingInterval);
	}
	
	void Shoot() 
	{

			Instantiate (bullet, transform.position, Quaternion.identity);
	}
	
	bool enemyInFront() 
	{
		// Raycast from the right of the game to the plant
		Vector2 origin = new Vector2(1000f, transform.position.y);
		RaycastHit[] hits = Physics.RaycastAll(origin, Vector2.right);
		
		// Find out if any Zombie was hit
		foreach (RaycastHit hit in hits) 
		{
			if (hit.collider != null &&
			    hit.collider.gameObject.tag == "Player")
			{
				return true;
			}
		}
		return false;
	}

	public void increaseFireRate(float n)
	{
		this.shootingInterval += n;
	}

	public void increaseDamage(int n)
	{
		this.bullet.GetComponent<BulletDamage> ().increaseDamage (n);
	}
}
