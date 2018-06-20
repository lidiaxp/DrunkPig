using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class life5 : MonoBehaviour {
	public int vidainicial = 500;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public Image morte;
	public Image inicio;
	public Image fim;
	public float flashSpeed = 10f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;

	andar5 andar5;
	bool isdead;
	AudioSource playerAudio;  
	bool damaged;
	static int chances = 3;
	int time;
	int help;
	bool death;
	int timer;
	int helpp = 0;
	bool pass = false;
	gotinp agua;
	static int iniciar = 0;

	void Awake () {
		andar5 = GetComponent<andar5> ();
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		if(chances == 3){
			inicio.enabled = true;
		}
		if (iniciar == 1) {
			inicio.enabled = false;
		}
		death = false;
		agua = FindObjectOfType (typeof(gotinp)) as gotinp;
	}

	void Update () {
		if (!inicio.enabled) {                    //ja pode andar
			andar5.enabled = true;
		}
		if (Time.timeSinceLevelLoad >= 65 && !pass) {   //nivel de tempo
			chances -= 1;
			Application.LoadLevel (Application.loadedLevel);
		}

		passardelevel ();

		if (damaged) {
			dano.color = flashcolor;
			damaged = false;
		} else {
			dano.color = Color.Lerp (dano.color, Color.clear, flashSpeed * Time.deltaTime);
		}

		if(Time.timeSinceLevelLoad >= 5){   //tempo para ler a cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}

		if(Input.GetButton("Fire1") && !pass){     //pular cutscene inicial
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}

		if(Input.GetButton("Fire1") && pass){       //pular cutscene final
			Application.LoadLevel ("nivel6");
		}

		if (help == 1) {     //tempo entre a morte e a reencarnaçao
			time = (int)Time.timeSinceLevelLoad + 4;
			help = 0;
		}

		if (death && !pass) {
			isdead = true;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
			andar5.enabled = false;
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

	void passardelevel(){
		if (agua.water >= 10) {
			helpp = 1;
			pass = true;
		}
		if (helpp == 1) {
			timer = (int)Time.timeSinceLevelLoad + 10;
			fim.enabled = true;
			helpp = 0;
		}
		if (Time.timeSinceLevelLoad >= timer && pass) {
			Application.LoadLevel ("nivel6");
		}
	}

	public void takedamage (int dor){
		if(!pass){
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
