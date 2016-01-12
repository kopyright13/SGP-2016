using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	
	Vector3 startingPosition;
	//Vector3 check1 = new Vector3(703,-291,0);
	Vector3 check2;
	Vector3 check4;
	static string loadedlevel;
	[SerializeField]
	public static int cur = 1;
	
	public void Awake()
	{

	}

	
	public void doDamage(int n)
	{
		// Subtract damage from current health
		cur -= n;
		
		// Destroy if died
		if (cur <= 0){
		Application.LoadLevel(Application.loadedLevel);
	}


		//Destroy (this.gameObject);
		
		//gameObject.active = false;
		//transform.position = startPosition;
		//gameObject.active = true;
		
		//GetComponent(MeshRenderer).enabled = false;
		
		//Spawn point poc that could be used
		//Instantiate (this.gameObject, GameObject.Find ("PlayerSpawnPoint").transform.position, Quaternion.identity);
	}
	
	public void heal(int n)
	{
		cur += n;
	}
	
}