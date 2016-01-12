using UnityEngine;
using System.Collections;

public class checkpoint4 : MonoBehaviour {
	
	// Use this for initialization
	public GameObject S;
	public GameObject G;
	public GameObject P;
	public int count = 0;
	
	
	void OnTriggerEnter(Collider col){
		if (col.name == "S") {
			if(count == 0){
				count++;
				S.gameObject.GetComponent<Health>().heal(2);
				G.gameObject.GetComponent<Health>().heal(2);
				P.gameObject.GetComponent<Health>().heal(2);
			}
			
		}
		else if(col.name == "P"){
			if(count == 0){
				count++;
				S.gameObject.GetComponent<Health>().heal(2);
				G.gameObject.GetComponent<Health>().heal(2);
				P.gameObject.GetComponent<Health>().heal(2);
			}
			
		}
		else if(col.name == "G"){
			if(count == 0){
				count++;
				S.gameObject.GetComponent<Health>().heal(2);
				G.gameObject.GetComponent<Health>().heal(2);
				P.gameObject.GetComponent<Health>().heal(2);
			}
			
		}
		
	}
	
}