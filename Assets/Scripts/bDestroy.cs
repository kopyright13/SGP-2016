using UnityEngine;
using System.Collections;
public class bDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		print ("hit");				
		Destroy (this.gameObject);
			
				
		}
}