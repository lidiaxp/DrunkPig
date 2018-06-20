using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class life9 : MonoBehaviour {
	public int vidainicial = 500;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public Image inicio;
	public Image morte;
	public Image fim;
	public Image teste;
	public float flashSpeed = 10f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;
	public GameObject bacon;
	public GameObject linguica;

	bool isdead;
	bool damaged;
	static int chances = 3;
	bool death;
	static int iniciar = 0;
	int help = 0;
	int time;
	int helpp = 0;
	int timee;

	AudioSource playerAudio; 
	andar9 andar;
	attackmelee9 atck;
	attackranged9 atck1;

	void Start () {
		atck = bacon.GetComponent<attackmelee9> ();
		atck1 = linguica.GetComponent<attackranged9> ();
		andar = GetComponent<andar9> ();       
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		if(chances == 3){              // chances no nivel
			inicio.enabled = true;
		}
		if (iniciar == 1) {               //so aparecer a cutscene inicial uma vez
			inicio.enabled = false;
		}
		death = false;
		atck.enabled = true;
		atck.enabled = true;
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
		//--------------------------------------------------------------------------------------
		if(help == 1){                             //espera 4 segundos
			teste.enabled = false;
			time = (int)Time.timeSinceLevelLoad + 4;
			help = 2;
		}
		if(help == 2){                               //reinicia o nivel
			if(time <= (int)Time.timeSinceLevelLoad){
				chances--;
				Application.LoadLevel (Application.loadedLevel);
			}
		}
		if(helpp == 1){                             //espera 8 segundos
			teste.enabled = false;
			timee = (int)Time.timeSinceLevelLoad + 8;
			helpp = 2;
		}
		if(helpp == 2){                               //passa pro nivel 10
			if(timee <= (int)Time.timeSinceLevelLoad){
				Application.LoadLevel ("nivel10");
			}
		}
		//--------------------------------------------------------------------------------------
		if(Time.timeSinceLevelLoad >= 7){   //tempo para ler a cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}
		//---------------------------------------------------------------------------------------
		if(fim.enabled && teste.enabled){        //se tiveres passado de nivel, nao podem mais te bater
			helpp = 1;
			atck.enabled = false;
			atck.enabled = false;
		}
		//---------------------------------------------------------------------------------------
		if(Input.GetButton("Fire1") && !fim.enabled && inicio.enabled){             //pular cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}
		if(Input.GetButton("Fire1") && fim.enabled && !morte.enabled){       //pular cutscene final
			Application.LoadLevel ("nivel10");
		}
		//---------------------------------------------------------------------------------------
		if (death && !fim.enabled) {
			isdead = true;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
			andar.enabled = false;
			morte.enabled = true;
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
