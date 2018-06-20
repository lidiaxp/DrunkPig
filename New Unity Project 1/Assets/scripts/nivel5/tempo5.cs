using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tempo5 : MonoBehaviour {
	Text text;       
	int time = 65;

	void Awake (){
		text = GetComponent <Text> ();
	}

	void Update (){
		if (time <= 0) {
			time = 0;
		} else {
			time = 65 - (int)Time.timeSinceLevelLoad;
		}
		text.text = "Tempo: " + time;
	}
}
