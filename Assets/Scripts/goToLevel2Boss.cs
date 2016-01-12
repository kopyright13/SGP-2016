using UnityEngine;
using System.Collections;

public class goToLevel2Boss : MonoBehaviour {
	public int countS = 0;
	public int countG = 0;
	public int countP = 0;
	// Update is called once per frame
	
	void OnTriggerEnter(Collider col)
	{
		if (col.name == "S" ) {
			countS = 1;
		} else if (col.name == "G") {
			countG = 1;
		} else if (col.name == "P") {
			countP = 1;
		}
		
	}
	void Update(){
		if(countS == 1 && countG == 1 && countP == 1){
			Application.LoadLevel ("Boss2");
		}}
}
