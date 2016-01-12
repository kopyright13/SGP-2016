using UnityEngine;
using System.Collections;

public class b3 : MonoBehaviour {
	public static int b3b;
	public int counter = 0;
	// Use this for initialization

	void OnTriggerEnter(){
		if (b1.b1b == 1 && b2.b2b == 1) {
			b3b = 1;
			print (b3b);
		} else if (b1.b1b == 1 && b2.b2b == 0) {
			b1.b1b = 0;
			print ("WRONG");
		}
	}
}
