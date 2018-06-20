using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tempo : MonoBehaviour {
	Text text;       
	public int time = 53;

	void Awake (){
		text = GetComponent <Text> ();
	}
	
	void Update (){
		if (time <= 0) {
			time = 0;
		} else {
			time = 53 - (int)Time.timeSinceLevelLoad;
		}
		text.text = "Tempo: " + time;
	}
}
