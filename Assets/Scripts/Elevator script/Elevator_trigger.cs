using UnityEngine;
using System.Collections;

public class Elevator_trigger : MonoBehaviour {
	public static bool open;
	public int count;
	public GameObject S;
	public GameObject G;
	public GameObject P;
	public GameObject elv;
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
			anim2.SetBool("cam_move",true);
			track = theValue;
		}

		if (theValue == 3) {
			print ("I think it works");
			track = theValue;
			//GetComponent<Animator>().SetBool ("Active", false);	
			GetComponent<Animator>().SetBool ("Active", false);
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
			anim2.SetBool("onsecondfloor",true);
			cam.transform.Translate (-22,-212,-112);
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
						countS = 1;
						print ("S is here");
				} 
		if (collider.gameObject == G) {
						count+=1;
						countG = 1;
						print ("G is here");	
				}
		if (collider.gameObject == P) {
						count+=1;
			            countP = 1;
						print ("P is here");	
				}
		if (count == 2 || count == 3)
						open = true;
		else if (count <= 1)
						open = false;

		print ("Someone entered the count is " + count);
		if (open == true) {
						GetComponent<Animator>().SetBool ("Active", true);	
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

		if (track == 2 && ScoreManager.score == 1 && count == 5) {
			print ("It goes");
			//newCamSwitch.count = 1;
			//Swop.activechar = 5;
			//newCamSwitch.check = LastFrameCheck.Frame;
			//Swop.activechar = 0;
			S.transform.Translate (0, -400, 0);
			G.transform.Translate (0, -400, 0);
			if (countP == 1)
				P.transform.Translate (150, -400, 0);
			countS = 0;
			countG = 0;
			countP = 0;
			print (countS);
			print (countG);
			print (countP);
			print (ScoreManager.score);
			track = 0;
			
		} 
		/*else if (floor1 == 1) {
			print ("It goes");
			newCamSwitch.check = LastFrameCheck.Frame;
			S.transform.Translate (0, -400, 0);
			G.transform.Translate (0, -400, 0);
			if (countP == 1)
				P.transform.Translate (150, -400, 0);
			countS = 0;
			countG = 0;
			countP = 0;
			print (countS);
			print (countG);
			print (countP);
			print (ScoreManager.score);
			
		} */
		else if (track == 3 && ScoreManager.score == 2 && countS == 1 && countG == 1 && countP == 1) {
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
