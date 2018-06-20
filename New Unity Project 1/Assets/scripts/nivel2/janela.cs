using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class janela : MonoBehaviour {
	public GameObject jack;
	public Image inicio;
	public Image fim;
	public Image devorado;

	int q = 0;
	float timer;
	int w = 0;
	float timerr;
	bool pass = false;
	static int iniciar = 0;

	andar andar;
	tempo2 tempo2;

	void Awake () {
		inicio.enabled = true;
		andar = jack.GetComponent<andar> ();
	}

	void Start(){
		if (iniciar == 1) {
			inicio.enabled = false;
		}
		tempo2 = FindObjectOfType (typeof(tempo2)) as tempo2;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			pass = true;
		}
	}

	void Update () {
		if(tempo2.time <= 0){      //seu tempo acabou e o musico te pegou
			devorado.enabled = true;
			w = 1;
		}
		if (w == 0) {
			timerr = Time.timeSinceLevelLoad + 4; // tempo da cena do devorado
		}
		if(Time.timeSinceLevelLoad >= timerr) {   //volta pro nivel 1 pq vc foi comido
			PlayerPrefs.SetInt ("save", 3);
			Application.LoadLevel("nivel1");
		}
		if (!inicio.enabled) {  //pode andar so quando a cutscene sai
			andar.enabled = true;
		}
		if(Input.GetButton("Fire1")){  //pular a cutscene
			iniciar = 1;
			inicio.enabled = false;
		}
		if(Input.GetButton("Fire1") && fim.enabled){  //pular a cutscene
			fim.enabled = false;
			Application.LoadLevel("nivel3");
		}
		if (q == 0) {
			timer = Time.timeSinceLevelLoad + 10; // tempo da cutscene no final
		}
		if (Time.timeSinceLevelLoad > 10) {   // tempo da cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
		}
		if (pass) {                           //como passar de nivel
			fim.enabled = true;
			q = 1;
			if(Time.timeSinceLevelLoad >= timer) {
				Application.LoadLevel("nivel3");
			}
		}
	}
}