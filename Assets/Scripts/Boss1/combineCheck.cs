﻿using UnityEngine;
using System.Collections;

public class combineCheck : MonoBehaviour {
	
	// Update is called once per frame
	void OnTriggerEnter () {
		ScoreManager.boss1 = 1;
	}
}
