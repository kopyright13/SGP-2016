using UnityEngine;
using System.Collections;

public class b2 : MonoBehaviour {
	public static int b2b;
	public int counter = 0;
	// Use this for initialization
	

	void OnTriggerEnter(){
		if (b1.b1b == 1) {
			b2b = 1;
			print (b2b);
		}
	}
}
