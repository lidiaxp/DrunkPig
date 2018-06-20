using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pause6 : MonoBehaviour {
	public GameObject jack;
	public Image pause;
	public Image inicio;
	public Image gotomenu;
	public Image restart;
	public Image muifazenda;
	public Image poucfactory;

	andar6 control;
	pontuaçao points;

	void Start () {
		control = jack.GetComponent<andar6> ();
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
		Time.timeScale = 1;
	}

	void Update () {
		if(!inicio.enabled && !muifazenda.enabled && !poucfactory.enabled){
			if(Input.GetKey(KeyCode.K)){
				restart.enabled = true;
				Time.timeScale = 0;
				control.enabled = false;
			}

			if(restart.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					points.fabricas = 0;
					points.fazendas = 0;
					control.enabled = true;
					Application.LoadLevel(Application.loadedLevel);
				}
				if(Input.GetKey(KeyCode.N)){
					restart.enabled = false;
					Time.timeScale = 1;
					control.enabled = true;
				}
			}

			if(Input.GetKeyDown(KeyCode.M)){
				gotomenu.enabled = true;
				Time.timeScale = 0;
				control.enabled = false;
			}

			if(gotomenu.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
					control.enabled = true;
					Application.LoadLevel("menu");
				}
				if(Input.GetKey(KeyCode.N)){
					gotomenu.enabled = false;
					Time.timeScale = 1;
					control.enabled = true;
				}
			}
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				control.enabled = false;
				pause.enabled = true;
			} else {
				Time.timeScale = 1;
				control.enabled = true;
				pause.enabled = false;
			}
		}
	}
}
