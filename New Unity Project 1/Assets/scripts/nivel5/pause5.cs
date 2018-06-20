using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pause5 : MonoBehaviour {
	public GameObject jack;
	public Image pause;
	public Camera cam;
	public Image inicio;
	public Image gotomenu;
	public Image restart;
	public Image die;

	andar5 control;
	paranoia paranoia;

	void Start () {
		control = jack.GetComponent<andar5> ();
		paranoia = cam.GetComponent<paranoia> ();
		Time.timeScale = 1;
	}

	void Update () {
		if(!inicio.enabled && !die.enabled){
			if(Input.GetKey(KeyCode.K)){
				restart.enabled = true;
				Time.timeScale = 0;
				paranoia.enabled = false;
				control.enabled = false;
			}

			if(restart.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
					Application.LoadLevel(Application.loadedLevel);
				}
				if(Input.GetKey(KeyCode.N)){
					restart.enabled = false;
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
				}
			}

			if(Input.GetKeyDown(KeyCode.M)){
				gotomenu.enabled = true;
				Time.timeScale = 0;
				paranoia.enabled = false;
				control.enabled = false;
			}

			if(gotomenu.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
					Application.LoadLevel("menu");
				}
				if(Input.GetKey(KeyCode.N)){
					gotomenu.enabled = false;
					Time.timeScale = 1;
					paranoia.enabled = true;
					control.enabled = true;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				paranoia.enabled = false;
				control.enabled = false;
				pause.enabled = true;
			} else {
				Time.timeScale = 1;
				paranoia.enabled = true;
				control.enabled = true;
				pause.enabled = false;
			}
		}
	}
}