using UnityEngine;
using System.Collections;

public class dpsInvis : MonoBehaviour {
		
	void OnTriggerEnter(Collider coll) 
	{
		if (coll.gameObject.tag == "Player") 
		{
				coll.gameObject.GetComponent<Health>().doDamage(1);
			}
		}
}
