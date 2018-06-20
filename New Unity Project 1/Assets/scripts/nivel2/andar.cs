using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class andar : MonoBehaviour {
	public static int frente = 15;
	public static float pulo = 1.8f;
	public Image bebum;
	public Image inicio;
	public Image fim;

	void Start () {
		
	}

	void Update () {
		if((int)Time.timeSinceLevelLoad%2==0){//parada das bolinhas na tela
			bebum.enabled = false;
		}else{
			bebum.enabled=true;
		}	
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-frente * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(frente * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(0,0,-10f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0,0,10f * Time.deltaTime);
		}
		if (Physics.Raycast(transform.position, -Vector3.up, 5)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.Translate (0, pulo, 0);
			}
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		}
		if(Input.GetKeyUp (KeyCode.B)){
			transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
		}
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,-75f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,75f * Time.deltaTime,0);
		}
	}
}
