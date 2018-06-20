using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class save6 : MonoBehaviour {
	public GameObject jack;
	public Image salvo;
	public Image salvar;
	public Image inicio;
	public Image pause;
	public Image muifazenda;
	public Image poucfactory;

	andar6 control;

	void Start () {
		control = jack.GetComponent<andar6> ();
	}

	void Update () {
		if(!inicio.enabled && !pause.enabled && !muifazenda.enabled && !poucfactory.enabled){
			if(!salvar.enabled && !salvo.enabled){
				if (Input.GetKeyUp (KeyCode.S)) {
					salvar.enabled = true;
					Time.timeScale = 0;
					control.enabled = false;
				}
			}

			if(salvar.enabled){
				if (Input.GetKeyDown (KeyCode.S)) {
					PlayerPrefs.SetInt ("save", 10);
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
