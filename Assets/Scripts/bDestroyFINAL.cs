using UnityEngine;
using System.Collections;
public class bDestroyFINAL : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		print ("hit");				
		Destroy (this.gameObject);
		Application.LoadLevel ("StartMenu");
			
				
		}
}