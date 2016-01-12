using UnityEngine;
using System.Collections;

public class blockKill : MonoBehaviour {

	float last = 0;
	
	void OnTriggerEnter(Collider coll) 
	{

		if (coll.gameObject.tag == "Player") 
		{
			print ("HIT");
			if (Time.time - last >= 1)
			{
				coll.gameObject.GetComponent<Health>().doDamage(1);
				last = Time.time;
			}
		
		else if (coll.gameObject.tag == "Block")
				print ("Oh NO!");}
	}
}
