using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class life7 : MonoBehaviour {
	public int vidainicial = 500;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public Image inicio;
	public Image mortefaca;
	public Image morteaviao;
	public Image mortemontanha;
	public Image fim;
	public float flashSpeed = 10f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;

	andar7 andar;
	bool isdead;
	AudioSource playerAudio;  
	bool damaged;
	static int chances = 3;
	bool death;
	static int iniciar = 0;
	int help = 0;
	int time;
	int helpp = 0;
	int timee;

	void Start () {
		andar = GetComponent<andar7> ();       
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		if(chances == 3){              // chances no nivel
			inicio.enabled = true;
		}
		if (iniciar == 1) {               //so aparecer a cutscene inicial uma vez
			inicio.enabled = false;
		}
		death = false;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Mountain"){
			mortemontanha.enabled = true;
			if (chances <= 0) {
				PlayerPrefs.SetInt ("save", 3);
				Application.LoadLevel ("nivel1");
			}
			help = 1;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
		}
		if(other.gameObject.tag == "Airplane"){
			morteaviao.enabled = true;
			if (chances <= 0) {
				PlayerPrefs.SetInt ("save", 3);
				Application.LoadLevel ("nivel1");
			}
			help = 1;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
		}
		if(other.gameObject.tag == "GiantWorld"){
			fim.enabled = true;
			timee = (int)Time.timeSinceLevelLoad + 8;
			helpp = 2;
		}
	}

	void Update () {
		if (!inicio.enabled) {            //ja pode andar
			andar.enabled = true;
		}
		if (damaged) {                                  //coisinha de dano
			dano.color = flashcolor;
			damaged = false;
		} else {
			dano.color = Color.Lerp (dano.color, Color.clear, flashSpeed * Time.deltaTime);
		}

		if(help == 1){                             //espera 4 segundos
			time = (int)Time.timeSinceLevelLoad + 4;
			help = 2;
		}
		if(help == 2){                               //reinicia o nivel
			if(time <= (int)Time.timeSinceLevelLoad){
				chances--;
				Application.LoadLevel (Application.loadedLevel);
			}
		}

		if(Time.timeSinceLevelLoad >= 6){   //tempo para ler a cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}

		if(Input.GetButton("Fire1") && !fim.enabled && inicio.enabled){             //pular cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}

		if(helpp == 2){ 
			if(timee <= (int)Time.timeSinceLevelLoad && fim.enabled && !mortefaca.enabled 
				&& !morteaviao.enabled && !mortemontanha.enabled){       //tempo para ler cutscene final
				Application.LoadLevel ("nivel8");
			}
		}

		if(Input.GetButton("Fire1") && fim.enabled && !mortefaca.enabled 
			&& !morteaviao.enabled && !mortemontanha.enabled){       //pular cutscene final
			Application.LoadLevel ("nivel8");
		}
			
		if (death && !fim.enabled) {
			isdead = true;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
			andar.enabled = false;
			mortefaca.enabled = true;
			if (time <= (int)Time.timeSinceLevelLoad) {
				if (chances > 0) {
					chances--;
					Application.LoadLevel (Application.loadedLevel);
				} else {
					PlayerPrefs.SetInt ("save", 3);
					Application.LoadLevel ("nivel1");
				}
			}
		}
	}

	public void takedamage (int dor){
		if (!fim.enabled) {
			damaged = true;
			vidasobrando -= dor;
			sliderdevida.value = vidasobrando;
			playerAudio.Play ();
			if (vidasobrando <= 0 && !isdead) {
				help = 1;
				death = true;
			}
		}
	}
}