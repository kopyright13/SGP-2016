using UnityEngine;
using System.Collections;

public class trigger_3 : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") {
						Swop3.found = 2;
				} 
	}
}