using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class save3 : MonoBehaviour {
	public GameObject jack;
	public GameObject lasero;
	public GameObject laserto;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image die;

	andar3 control;
	tirofrente laser;
	tirotras lasert;

	void Awake () {
		control = jack.GetComponent<andar3> ();
		laser = lasero.GetComponent<tirofrente> ();
		lasert = laserto.GetComponent<tirotras> ();
	}
	
	void Update () {
		if(!inicio.enabled && !pause.enabled && !die.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					control.enabled = false;
					laser.enabled = false;
					lasert.enabled = false;
				}
			}

			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 7);
					salvar.enabled = false;
					salvo.enabled = true;
				}
				if (Input.GetKeyDown (KeyCode.N)) {
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
					salvar.enabled = false;
				}
			}

			if(salvo.enabled){
				if (Input.GetKeyDown (KeyCode.O)) {
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
					salvo.enabled = false;
				}
			}
		}
	}
}
