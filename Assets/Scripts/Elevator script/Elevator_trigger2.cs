using UnityEngine;
using System.Collections;

public class Elevator_trigger2 : MonoBehaviour {
	public static bool open;
	public int count;
	public GameObject S;
	public GameObject G;
	public GameObject P;
	public GameObject cam;
	public Animator anim;
	public Animator anim2;

	public static int countS = 0;
	public static int countG = 0;
	public static int countP = 0;

	public static float track = 0;
	public static float floor1 = 0;


	// Use this for initialization
	void Start () {
		//GetComponent<Animator> ().SetBool ("Active", false);
		count = 0;
	
	}
	void PrintFloat (float theValue) {
		Debug.Log ("PrintFloat is called with a value of " + theValue);
		if (theValue == 2) 
		{
			//anim2.SetBool("cam_move",true);
			track = theValue;
			anim2.SetBool("cam_move2",true);
		}

		if (theValue == 3) {
			print ("I think it works");
			track = theValue;
			//GetComponent<Animator>().SetBool ("Active", false);	
			GetComponent<Animator>().SetBool ("Active2", false);

			//newCamSwitch.count = 5;
			//anim2.SetBool("cam_move",true);
			//anim.SetBool ("Door_Check", true);	
			//Application.LoadLevel ("Floor2");
			newCamSwitch.count = 5;
			Swop.activechar = 5;
		}

	}

	void PrintFloat2 (float theValue) {
		if (theValue == 4)
		{
			track = theValue;
			//anim2.SetBool("onsecondfloor",true);
			//newCamSwitch.count = 5;
			//Swop.activechar = 5;
			//GetComponent<Animator>().SetBool ("Active2", false);	
			print ("second animation works");
		}
	

	}

	void OnTriggerEnter(Collider collider){
		print ("Touch Down!");

		if (collider.gameObject == S ) {
						count+=1;
						print ("S is here");
				} 
		if (collider.gameObject == G) {
						count+=1;
						print ("G is here");	
				}
		if (collider.gameObject == P) {
						count+=1;
						print ("P is here");	
				}
		if (count == 3)
						open = true;
		else if (count <= 2)
						open = false;

		print ("Someone entered the count is " + count);
		if (open == true) {
						GetComponent<Animator>().SetBool ("Active2", true);	
				}
	}
	void OnTriggerExit(Collider colliders){
		if (colliders.gameObject == S || colliders.gameObject == G || colliders.gameObject == P) {
						count-=1;
			print ("Someone left the count is " + count);
				}
	}
	// Update is called once per frame
	void Update () {
			 if (track == 3 && ScoreManager.score == 2 && count == 3) {
			newCamSwitch.count = 1;
			Swop.activechar = 0;
			S.transform.Translate (150, -450, 0);

			G.transform.Translate (150, -400, 0);
			P.transform.Translate (150, -400, 0);
			countS++;
			countG++;
			countP++;
		}
	 }

}
