using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class save9 : MonoBehaviour {
	public GameObject jacksingle;
	public GameObject lasero;
	public GameObject laserto;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image die;
	public Image fim;

	andar9 control;
	tiro9 laser;
	tiropratras9 lasert;

	void Start () {
		control = jacksingle.GetComponent<andar9> ();
		laser = lasero.GetComponent<tiro9> ();
		lasert = laserto.GetComponent<tiropratras9> ();
	}

	void Update () {
		if(!inicio.enabled && !pause.enabled && !die.enabled && !fim.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					control.enabled = false;
				}
			}

			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 13);
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
