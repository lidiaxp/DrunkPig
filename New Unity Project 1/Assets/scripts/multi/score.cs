using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public int pontos; 

	Text text;                     
	void Awake (){
		text = GetComponent <Text> ();
		pontos = 0;
	}

	void Update (){
		text.text = "Score: " + pontos;
	}
}
