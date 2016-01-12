using UnityEngine;
using System.Collections;

public class EnemyAttack2 : MonoBehaviour {

	//float last = 0;
	
	void OnCollisionStay(Collision coll) 
	{
		if (coll.gameObject.tag == "Player") 
		{
				coll.gameObject.GetComponent<Health>().doDamage(1);
			    
		}
	}

}
