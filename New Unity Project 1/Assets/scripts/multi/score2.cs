using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score2 : MonoBehaviour {
	public int pontos2;
	
	Text text;                     
	void Awake (){
		text = GetComponent <Text> ();
		pontos2 = 0;
	}
	
	void Update (){
		text.text = "Score: " + pontos2;
	}
}
