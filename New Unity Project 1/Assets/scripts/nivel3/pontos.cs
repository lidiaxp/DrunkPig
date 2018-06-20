using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pontos : MonoBehaviour {
	public int ponto;
	public Image inicio;
	
	Text text;    

	void Awake (){
		text = GetComponent <Text> ();
		ponto = 0;
	}
	
	void Update (){
		if(Time.timeSinceLevelLoad >= 30 || Input.GetKey (KeyCode.Mouse0) || !inicio.enabled){
			text.enabled = true;
			text.text = "      Score: " + ponto;
		}
	}
}
