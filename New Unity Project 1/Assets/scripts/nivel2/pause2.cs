using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pause2 : MonoBehaviour {
	public GameObject jacksingle;
	public Image imagem;
	public Image inicio;
	public Image gotomenu;
	public Image restart;
	public Image die;
	
	andar control;
	
	void Awake () {
		control = jacksingle.GetComponent<andar> ();
		Time.timeScale = 1;
	}
	
	void Update () {
		if(!inicio.enabled && !die.enabled){
			if(Input.GetKey(KeyCode.K)){
				restart.enabled = true;
				Time.timeScale = 0;
				control.enabled = false;
			}

			if(restart.enabled){
				if(Input.GetKey(KeyCode.S)){
					Time.timeScale = 1;
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
		
		if(Input.GetKeyDown(KeyCode.P)){
			if(Time.timeScale == 1){
				Time.timeScale = 0;
				control.enabled = false;
				imagem.enabled = true;
			}else{
				Time.timeScale = 1;
				control.enabled = true;
				imagem.enabled = false;
			}
		}
	}
}
