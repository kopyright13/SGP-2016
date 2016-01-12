using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int score;
	public static int boss1;
	Text text;
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		score = 0;
		boss1 = 0;
		DontDestroyOnLoad(this);

	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Blue Print " + score + "/3";
		if (score == 2) 
			text.text = "2/3";
		else if(score == 3)
			text.text = "3/3";

			if(boss1 == 1){
				text.text = "Press DownArrow to Combine!";
			}
		}
	}

