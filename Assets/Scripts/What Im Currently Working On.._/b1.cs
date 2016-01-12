using UnityEngine;
using System.Collections;

public class b1 : MonoBehaviour {
	public static int b1b;
	public static int counter = 0;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
	if ( counter == 0 && b1b == 1 && b2.b2b == 1 && b3.b3b == 1) {
			bombMag1.counter = 1;
			b1b = 0;
			b2.b2b = 0;
			b3.b3b = 0;
			counter = 1;
			print ("Counter:");
			print (counter);
		}
		else if (counter == 1 && b1b == 1 && b2.b2b == 1 && b3.b3b == 1){
			bombMag2.counter = 1;
			b1b = 0;
			b2.b2b = 0;
			b3.b3b = 0;
			counter = 2;
		}
		else if (counter == 2 && b1b == 1 && b2.b2b == 1 && b3.b3b == 1){
			bombMag3.counter = 1;
		}
	}
	void OnTriggerEnter(){
	if (b1b == 0) {
			b1b = 1;
			print (b1b);
		}
	}
}
