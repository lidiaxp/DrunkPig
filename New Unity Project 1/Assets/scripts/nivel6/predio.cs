using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class predio : MonoBehaviour {
	public Image inicio;
	public Image fim;
	public Image muifazenda;
	public Image poucfactory;
	public GameObject jack;

	pontuaçao points;
	static int chance = 3;
	int help = 0;
	int time = 700;
	int helpp = 0;
	int timee = 700;
	andar6 control;
	bool pass = false;
	andar6 andar;
	static int iniciar = 0;

	void Start () {
		poucfactory.enabled = false;
		muifazenda.enabled = false;
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
		andar = FindObjectOfType (typeof(andar6)) as andar6;
		control = jack.GetComponent<andar6> ();
		control.enabled = false;
		if(chance == 3){
			inicio.enabled = true;
		}
		if (iniciar == 1) {
			inicio.enabled = false;
		}
	}

	void OnTriggerEnter (Collider other){      //logica de passar de nivel
		if(other.gameObject.tag == "Player"){
			if (points.fabricas <= 20 && !poucfactory.enabled && !muifazenda.enabled) {
				chance--;
				control.enabled = false;
				poucfactory.enabled = true;
				helpp = 1;
			} else {
				pass = true;
				control.enabled = false;
				fim.enabled = true;
				help = 1;
			}
		}	
	}

	void Update () {
		if (!inicio.enabled) {
			control.enabled = true;
		}
		if(Input.GetButton("Fire1") && !pass){
			iniciar = 1;
			inicio.enabled = false;
			control.enabled = true;
		}
		if(Input.GetButton("Fire1") && pass){
			Application.LoadLevel ("nivel7");
		}
		if(Time.timeSinceLevelLoad > 10){
			iniciar = 1;
			inicio.enabled = false;
			control.enabled = true;
		}
		if (points.fazendas > 3) {
			andar.enabled = false;
			chance--;
			control.enabled = false;
			muifazenda.enabled = true;
			points.fazendas = 0;
			points.fabricas = 0;
			helpp = 1;
		}
		if(help == 1){                               //tempo q o fim aparece
			time = (int)Time.timeSinceLevelLoad + 9;
			help = 0;
		}
		if (time < (int)Time.timeSinceLevelLoad) {
			Application.LoadLevel ("nivel7");
		}
		if (helpp == 1) {
			timee = (int)Time.timeSinceLevelLoad + 4;
			helpp = 0;
		}
		if (timee < (int)Time.timeSinceLevelLoad) {
			if (chance <= 0) {
				PlayerPrefs.SetInt ("save", 3);
				Application.LoadLevel ("nivel1");
			} else {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}