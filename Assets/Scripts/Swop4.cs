using UnityEngine;
using System.Collections;

public class Swop4 : MonoBehaviour {
	
	public GameObject S;
	public GameObject P;
	public GameObject G;
	public GameObject SPG;
	public static int activechar;
	public static int roar;

	//Here I was trying to refer to the blueprint class
	//using this it would return a value
	//GameObject go = GameObject.Find ("Cube");
	//BluePrint blueprint = go.GetComponent <BluePrint> ();
	//int count = blueprint.num(go);

	//This was commented out so that i could test the incoming  value
	//public int activechar = 0; // when 0 active character is char1, when 1 active character is char2, etc.
	
	// Use this for initialization
	void Start () {
	
		//this would set the value of the in coming value to from the othe class
		//activechar = count;
		activechar = 0;
		//S.SetActive(true);
		//P.SetActive(false);
		//G.SetActive(false);
		//SPG.SetActive(false);
		roar = 0;
	}

	// Update is called once per frame
	void Update () {
		if (activechar == 5){
			if(Input.GetKeyUp (KeyCode.Return)){
				activechar = 0;

			}
		}
		if(Input.GetKeyDown(KeyCode.E) && roar == 0)//if they press E the active char is switched
		{
			activechar++;
			if(activechar > 2)
				activechar = 0;  // makes sure it cycles through your 3 characters
		}
		if(Input.GetKeyDown(KeyCode.DownArrow) && ScoreManager.score == 2)//if they press E the active char is switched
		{
			activechar = 3;
			roar = 1;
		}
		OnEnable(); //calls the IsActive function to see which sprite is enabled
	}
	void OnEnable()
	{
		//this checked to see if the user was still using the three individual characters
		//while (activechar != 13) {

						if (activechar == 0) { //shows only char 1
								S.SetActive (true);
								S.GetComponent<Renderer>().gameObject.SetActive (true);

								P.SetActive (false);
								P.GetComponent<Renderer>().gameObject.SetActive (true);

								G.SetActive (false);
								G.GetComponent<Renderer>().gameObject.SetActive (true);

								SPG.SetActive (false);
								SPG.GetComponent<Renderer>().gameObject.SetActive (false);

						}
						if (activechar == 1) { //shows only char 2
								S.SetActive (false);  
								S.GetComponent<Renderer>().gameObject.SetActive (true);

								P.SetActive (false);
								P.GetComponent<Renderer>().gameObject.SetActive (true);

								G.SetActive (true);
								G.GetComponent<Renderer>().gameObject.SetActive (true);

								SPG.SetActive (false);
								SPG.GetComponent<Renderer>().gameObject.SetActive (false);
						}
						if (activechar == 2) { //shows only char 3
								S.SetActive (false);
								S.GetComponent<Renderer>().gameObject.SetActive (true);

								P.SetActive (true);
								P.GetComponent<Renderer>().gameObject.SetActive (true);

								G.SetActive (false);
								G.GetComponent<Renderer>().gameObject.SetActive (true);

								SPG.SetActive (false);
								SPG.GetComponent<Renderer>().gameObject.SetActive (false);
						}
		//}
		//lets the user use SGP
		if(activechar == 3) //shows only char 3
		{
			S.SetActive(false);
			S.GetComponent<Renderer>().gameObject.SetActive(false);
			P.SetActive(false);
			P.GetComponent<Renderer>().gameObject.SetActive(false);
			G.SetActive(false);
			G.GetComponent<Renderer>().gameObject.SetActive(false);
			SPG.SetActive(true);
			SPG.GetComponent<Renderer>().gameObject.SetActive(true);
		}
	}
}

