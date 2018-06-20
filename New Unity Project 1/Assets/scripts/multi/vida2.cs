using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class vida2 : MonoBehaviour {

	public int vidainicial = 100;
	public int vidasobrando;
	public Slider sliderdevida;
	public Image dano;
	public float flashSpeed = 5f;
	public Color flashcolor = new Color(1f,0f,0f,0.1f);
	public AudioClip jackreversomorte;
	
	controleplayer2 controleplayer2;
	redlgbt redlgbt;
	bool isdead;
	bool damaged;
	AudioSource playerAudio; 
	score pontos;
	int attack= 10;
	int ponto = 3;
	
	void Awake () {
		controleplayer2 = GetComponent<controleplayer2> ();
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		redlgbt = GetComponent<redlgbt> ();
		pontos = FindObjectOfType (typeof(score)) as score;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Bala"){
			pontos.pontos += ponto;
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
		playerAudio.clip = jackreversomorte;
		playerAudio.Play ();
		controleplayer2.enabled = false;
		//redlgbt.enabled = false;
	}
}
