using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class vida : MonoBehaviour {

	public int vidainicial = 100;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public float flashSpeed = 5f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackmorte;

	controleplayer controleplayer;
	redlgbt redlgbt;
	bool isdead;
	AudioSource playerAudio;  
	bool damaged;
	int attack= 10;
	int ponto = 3;
	score2 pontos;

	void Awake () {
		controleplayer = GetComponent<controleplayer> ();
		vidasobrando = vidainicial;
		redlgbt = GetComponent<redlgbt> ();
		playerAudio = GetComponent <AudioSource> ();
		pontos = FindObjectOfType (typeof(score2)) as score2;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Bala2"){
			pontos.pontos2 += ponto;
			takedamage (attack);
		}
	}

	void Update () {
		if (transform.position.y < -20) {
			vidasobrando = 0;
		}
	    if (damaged) {
			dano.color = flashcolor;
		} else {
			dano.color = Color.Lerp (dano.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}

	public void takedamage (int dor){
		damaged = true;
		vidasobrando -= dor;
		sliderdevida.value = vidasobrando;
		playerAudio.Play ();
		if(vidasobrando<=0 && !isdead){
			death ();
		}
	}

	void death(){
		isdead = true;
		playerAudio.clip = jackmorte;
		playerAudio.Play ();
		controleplayer.enabled = false;
		//redlgbt.enabled = false;
	}
}
