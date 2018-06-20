using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pauseemenu : MonoBehaviour {

	public GameObject jack;
	public GameObject lasero;
	public GameObject laserto;
	public Image imagem;
	public Image gotomenu;
	public GameObject jackreverso;
	public GameObject lasero2;
	public GameObject laserto2;

	controleplayer control;
	tiro laser;
	tiropratras lasert;
	controleplayer2 control2;
	tiro2 laser2;
	tiropratras2 lasert2;

	void Awake () {
		control = jack.GetComponent<controleplayer> ();
		laser = lasero.GetComponent<tiro> ();
		lasert = laserto.GetComponent<tiropratras> ();
		control2 = jackreverso.GetComponent<controleplayer2> ();
		laser2 = lasero2.GetComponent<tiro2> ();
		lasert2 = laserto2.GetComponent<tiropratras2> ();
		Time.timeScale = 1;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.M)){
			gotomenu.enabled = true;
			Time.timeScale = 0;
			control.enabled = false;
			laser.enabled = false;
			lasert.enabled = false;
			control2.enabled = false;
			laser2.enabled = false;
			lasert2.enabled = false;
		}

		if(gotomenu.enabled){
			if(Input.GetKey(KeyCode.S)){
				Time.timeScale = 1;
				control.enabled = true;
				laser.enabled = true;
				lasert.enabled = true;
				control2.enabled = true;
				laser2.enabled = true;
				lasert2.enabled = true;
				Application.LoadLevel("menu");
			}
			if(Input.GetKey(KeyCode.N)){
				gotomenu.enabled = false;
				Time.timeScale = 1;control.enabled = true;
				laser.enabled = true;
				lasert.enabled = true;
				control2.enabled = true;
				laser2.enabled = true;
				lasert2.enabled = true;
			}
		}

		if(Input.GetKeyDown(KeyCode.P)){
			if(Time.timeScale == 1){
				Time.timeScale = 0;
				control.enabled = false;
				laser.enabled = false;
				lasert.enabled = false;
				imagem.enabled = true;
				control2.enabled = false;
				laser2.enabled = false;
				lasert2.enabled = false;
			}else{
				Time.timeScale = 1;
				control.enabled = true;
				laser.enabled = true;
				lasert.enabled = true;
				imagem.enabled = false;
				control2.enabled = true;
				laser2.enabled = true;
				lasert2.enabled = true;
			}
		}
	}
}