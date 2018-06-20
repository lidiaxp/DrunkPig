using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pause9 : MonoBehaviour {
	public GameObject jack;
	public GameObject lasero;
	public GameObject laserto;
	public Image pause;
	public Image gotomenu;
	public Image inicio;
	public Image restart;
	public Image die;
	public Image fim;

	andar9 control;
	tiro9 laser;
	tiropratras9 lasert;

	void Start () {
		control = jack.GetComponent<andar9> ();
		laser = lasero.GetComponent<tiro9> ();
		lasert = laserto.GetComponent<tiropratras9> ();
		Time.timeScale = 1;
	}

	void Update () {
		if(!inicio.enabled && !die.enabled && !fim.enabled){
			if(Input.GetKey(KeyCode.K)){
				restart.enabled = true;
				Time.timeScale = 0;
				control.enabled = false;
				laser.enabled = false;
				lasert.enabled = false;
			}

			if(restart.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
					Application.LoadLevel(Application.loadedLevel);
				}
				if(Input.GetKey(KeyCode.N)){
					restart.enabled = false;
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
				}
			}

			if(Input.GetKeyDown(KeyCode.M)){
				gotomenu.enabled = true;
				Time.timeScale = 0;
				control.enabled = false;
				laser.enabled = false;
				lasert.enabled = false;
			}

			if(gotomenu.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
					Application.LoadLevel("menu");
				}
				if(Input.GetKey(KeyCode.N)){
					gotomenu.enabled = false;
					Time.timeScale = 1;
					control.enabled = true;
					laser.enabled = true;
					lasert.enabled = true;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				control.enabled = false;
				laser.enabled = false;
				lasert.enabled = false;
				pause.enabled = true;
			} else {
				Time.timeScale = 1;
				control.enabled = true;
				laser.enabled = true;
				lasert.enabled = true;
				pause.enabled = false;
			}
		}
	}
}
