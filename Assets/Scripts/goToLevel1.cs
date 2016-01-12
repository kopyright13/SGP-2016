using UnityEngine;
using System.Collections;

public class goToLevel1 : MonoBehaviour {

	public int countS;
	public int countG;
	public int countP;



	void OnTriggerEnter(Collider col)
	{

		if(col.name == "S")
			countS = 1;
		else if(col.name == "G")
			countG = 1;
		else if (col.name == "P")
			countP = 1;

	}
	void LateUpdate(){
				if (countS == 1 && countG == 1 && countP == 1) {
						Application.LoadLevel ("Level1Transition");
				}
		}
}
