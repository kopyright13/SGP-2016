using UnityEngine;
using System.Collections;

public class blockKillplayer : MonoBehaviour {

	float last = 0;
	
	void OnTriggerEnter(Collider coll) 
	{
		if (coll.gameObject.tag == "Block") {
			coll.gameObject.GetComponent<Health>().doDamage(1);
		}
		else if (coll.gameObject.tag == "Player") 
		{
			print ("HIT");

			/*if (Time.time - last >= 1)
			{
				coll.gameObject.GetComponent<Health>().doDamage(1);
				//last = Time.time;
			}*/
		}
	}

}
