using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class life4 : MonoBehaviour {

	public int vidainicial = 500;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public Image morte;
	public Image inicio;
	public float flashSpeed = 5f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;
	
	jack andar3;
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
		andar3 = GetComponent<jack> ();
		vidasobrando = vidainicial;
		redlgbt = GetComponent<redlgbt> ();
		playerAudio = GetComponent <AudioSource> ();
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
		if (!inicio.enabled) {
			andar3.enabled = true;
		}
		if (transform.position.x > 410) {
			takedamage (1);
		}
		if (damaged) {
			dano.color = flashcolor;
		} else {
			dano.color = Color.Lerp (dano.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
		if(Time.timeSinceLevelLoad >= 12 || Input.GetKey(KeyCode.Mouse0)){
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
