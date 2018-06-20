using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class celeiro : MonoBehaviour {
	public GameObject jack;
	public Image inicio;
	public Image fim;
	public Image sede;

	agua aguaa;
	bool passou = false;
	float time;
	float timer;
	float timerr;
	bool sedes = false;
	static int chances = 10;
	int q = 0;
	int tempototal = 53;
	static int iniciar = 0;

	tempo tempo;
	movimento andar;

	void Start () {
		andar = jack.GetComponent<movimento> ();
		aguaa = FindObjectOfType (typeof(agua)) as agua;
		if(chances == 10){
			inicio.enabled = true;
		}
		if (iniciar == 1) {
			inicio.enabled = false;
		}
		tempo = FindObjectOfType (typeof(tempo)) as tempo;
		andar = jack.GetComponent<movimento> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Player"){
			if(aguaa.water >= 20){
				fim.enabled = true;
				passou = true;
				time = Time.timeSinceLevelLoad + 10;//tempo para ler a cutscene do final
			}else{
				sede.enabled = true;
				andar.enabled = false;
				timer = Time.timeSinceLevelLoad + 3;//diz q ainda ta com sede e manda a foto de sede
				sedes = true;
			}
		}
	}

	void Update () {
		if (!inicio.enabled) {
			andar.enabled = true;
		}
		if(Input.GetButton("Fire1") && fim.enabled){
			Application.LoadLevel("nivel2");
		}
		if (q == 0) {
			timerr = Time.timeSinceLevelLoad + 5; //pra contar o tempo da foto com sede
		}
		if (Time.timeSinceLevelLoad >= tempototal  && !passou) { //a foto de ainda ta com sede aparece
			q = 1;
			sede.enabled = true;
			if(Time.timeSinceLevelLoad >= timerr) {
				chances--;
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		if (Input.GetKey (KeyCode.Mouse0)) {
			iniciar = 1;
			inicio.enabled = false;
		}
		if (Time.timeSinceLevelLoad > 8) {
			iniciar = 1;
			inicio.enabled = false;         // 8 segundos pra imagem do inicio
		}
		if(Time.timeSinceLevelLoad >= time && passou){//tem agua suficiente e esta no tempo
			Application.LoadLevel("nivel2");
		}
		if (sedes && Time.timeSinceLevelLoad >= timer) {//dps q passa o tempo de sede reinicia o nivel
			chances--;
			Application.LoadLevel("nivel1");
		}
	}
}
