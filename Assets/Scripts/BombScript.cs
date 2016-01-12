using UnityEngine;
using System.Collections;

public class BombScript : MonoBehaviour {

	public int damage = 2;

	public bool isEnemyShot = false;

	void Start () 
	{
		Destroy (gameObject, 1);
	}
	
}
