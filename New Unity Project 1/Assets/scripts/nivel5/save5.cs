using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class save5 : MonoBehaviour {
	public GameObject jacksingle;
	public Camera cam;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image die;

	andar5 control;
	paranoia paranoia;

	void Awake () {
		control = jacksingle.GetComponent<andar5> ();
		paranoia = cam.GetComponent<paranoia> ();
	}

	void Update () {
		if(!inicio.enabled && !pause.enabled && !die.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					paranoia.enabled = false;
					control.enabled = false;
				}
			}

			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 9);
					salvar.enabled = false;
					salvo.enabled = true;
				}
				if (Input.GetKeyDown (KeyCode.N)) {
					salvar.enabled = false;
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
				}
			}

			if(salvo.enabled){
				if (Input.GetKeyDown (KeyCode.O)) {
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
					salvo.enabled = false;
				}
			}
		}
	}
}
