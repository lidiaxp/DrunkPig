using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tempo2 : MonoBehaviour {
	Text text;       
	public int time = 60;

	void Start () {
		text = GetComponent <Text> ();
	}

	void Update () {
		if (time <= 0) {
			time = 0;
		} else {
			time = 60 - (int)Time.timeSinceLevelLoad;
		}
		text.text = "Tempo: " + time;
	}
}