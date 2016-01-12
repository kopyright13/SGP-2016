using UnityEngine;
using System.Collections;

public class elevator_2_Down : MonoBehaviour {
	
	// Use this for initialization
	public GameObject S;
	public GameObject G;
	public GameObject P;
	public int count = 0;
	
	
	void OnTriggerEnter(Collider col){
		if (col.name == "S") {
			S.transform.Translate(+100,-400,0);
			if(count == 0){
				count++;
				S.gameObject.GetComponent<Health>().heal(2);
				G.gameObject.GetComponent<Health>().heal(2);
				P.gameObject.GetComponent<Health>().heal(2);
			}

		}
		else if(col.name == "P"){
			P.transform.Translate(+100,-410,0);

		}
		else if(col.name == "G"){
			G.transform.Translate(+100,-410,0);
			if(count == 0){
				count++;
				S.gameObject.GetComponent<Health>().heal(2);
				G.gameObject.GetComponent<Health>().heal(2);
				P.gameObject.GetComponent<Health>().heal(2);
			}

		}

	}
	
}