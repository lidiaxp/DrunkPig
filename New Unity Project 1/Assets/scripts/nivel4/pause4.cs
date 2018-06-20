using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pause4 : MonoBehaviour {

	public GameObject jack;
	public GameObject lasero;
	public GameObject laserto;
	public Image pause;
	public Image inicio;
	public Image gotomenu;
	public Image restart;
	public Image die;
	
	jack control;
	tf4 laser;
	tt4 lasert;
	
	void Awake () {
		control = jack.GetComponent<jack> ();
		laser = lasero.GetComponent<tf4> ();
		lasert = laserto.GetComponent<tt4> ();
		Time.timeScale = 1;
	}
	
	void Update () {
		if(!inicio.enabled && !die.enabled){
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

		if(Input.GetKeyDown(KeyCode.P)){
			if(Time.timeScale == 1){
				Time.timeScale = 0;
				control.enabled = false;
				laser.enabled = false;
				lasert.enabled = false;
				pause.enabled = true;
			}else{
				Time.timeScale = 1;
				control.enabled = true;
				laser.enabled = true;
				lasert.enabled = true;
				pause.enabled = false;
			}
		}
	}
}
