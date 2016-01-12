using UnityEngine;
using System.Collections;

public class pushBlow : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Block" || other.tag == "Player") 
		{
			Destroy (this.gameObject);
		}
	}
}