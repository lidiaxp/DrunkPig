using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class save8 : MonoBehaviour {
	public GameObject jacksingle;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image die1;
	public Image die2;
	public Image fim;

	andar8 control;

	void Awake () {
		control = jacksingle.GetComponent<andar8> ();
	}

	void Update () {
		if(!inicio.enabled && !pause.enabled && !die1.enabled && !die2.enabled && !fim.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					control.enabled = false;
				}
			}

			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 12);
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
