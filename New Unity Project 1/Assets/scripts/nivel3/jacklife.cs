using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jacklife : MonoBehaviour {
	
	public int vidainicial = 100;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public Image morte;
	public Image inicio;
	public float flashSpeed = 5f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;
	
	andar3 andar3;
	redlgbt redlgbt;
	bool isdead;
	AudioSource playerAudio;  
	bool damaged;
	int chances = 3;
	int time;
	int help;
	bool death;
	static int iniciar = 0;
	
	void Awake () {
		andar3 = GetComponent<andar3> ();
		vidasobrando = vidainicial;
		redlgbt = GetComponent<redlgbt> ();
		playerAudio = GetComponent <AudioSource> ();
		sliderdevida.enabled = false;
		if(chances == 3){
			inicio.enabled = true;
		}
		if (iniciar == 1) {
			inicio.enabled = false;
		}
		death = false;
	}
	
	void OnTriggerEnter (Collider other){

	}
	
	void Update () {
		if (damaged) {
			dano.color = flashcolor;
		} else {
			dano.color = Color.Lerp (dano.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
		if(Time.timeSinceLevelLoad >= 25){
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}
		if (Input.GetKey (KeyCode.Mouse0) || !inicio.enabled) {
			iniciar = 1;
			inicio.enabled = false;
			sliderdevida.enabled = true;
		}
		if (help == 1) {
			time = (int)Time.timeSinceLevelLoad + 4;
			help = 0;
		}
		if (death) {
			isdead = true;
			playerAudio.clip = jackmorte;
			playerAudio.Play ();
			andar3.enabled = false;
			morte.enabled = true;
			if(time <= (int)Time.timeSinceLevelLoad){
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
