using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	//float last = 0;
	
	void OnCollisionStay(Collision coll) 
	{
		if (coll.gameObject.tag == "Player") 
		{
				coll.gameObject.GetComponent<Health>().doDamage(2);
		}
	}

}
