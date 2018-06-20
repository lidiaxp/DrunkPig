using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class save : MonoBehaviour {
	public GameObject jacksingle;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image sede;

	movimento control;

	void Awake(){
		control = jacksingle.GetComponent<movimento> ();
	}

	void Update () {
		if(!inicio.enabled && !pause.enabled && !sede.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					control.enabled = false;
				}
			}
				
			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 3);
					salvar.enabled = false;
					salvo.enabled = true;
				}
				if (Input.GetKeyDown (KeyCode.N)) {
					salvar.enabled = false;
					Time.timeScale = 1;
					control.enabled = true;
				}
			}
				
			if(salvo.enabled){
				if (Input.GetKeyDown (KeyCode.O)) {
					Time.timeScale = 1;
					control.enabled = true;
					salvo.enabled = false;
				}
			}
		}
	}
}
