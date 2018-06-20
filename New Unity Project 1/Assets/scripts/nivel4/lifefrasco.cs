using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lifefrasco : MonoBehaviour {

	public int vidainicial = 250;
	public int vidasobrando;
	public Image sliderp1;
	public Image sliderp2;
	public GameObject jack;
	public Image fim;
	public Slider sliderdevida;
	public Image explosao;
	public AudioClip explosaosound;
	
	AudioSource playerAudio; 
	bool deathc;
	int helpc;
	int time = 0;
	int timer = 0;
	life4 life4;

	void Awake () {
		vidasobrando = vidainicial;
		playerAudio = GetComponent <AudioSource> ();
		sliderp1.enabled = false;
		sliderp2.enabled = false;
		life4 = GetComponent <life4> ();
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.tag == "Bala"){
			takedamage(10);
		}
	}
	
	void Update () {
		if (jack.transform.position.y > 493) {
			sliderp1.enabled = true;
			sliderp2.enabled = true;
		} else {
			sliderp1.enabled = false;
			sliderp2.enabled = false;
		}
	
		if (helpc == 1) {
			time = (int)Time.timeSinceLevelLoad + 3;
			timer = (int)Time.timeSinceLevelLoad + 12;
			helpc = 0;
			deathc = true;
		}
		if (deathc) {
			playerAudio.clip = explosaosound;
			playerAudio.Play ();
			explosao.enabled = true;
			if(time <= (int)Time.timeSinceLevelLoad){
				explosao.enabled = false;
				fim.enabled = true;
				if(timer <= (int)Time.timeSinceLevelLoad || Input.GetKey(KeyCode.Mouse0)){
					Application.LoadLevel("nivel5");
				}
			}

		}
	}
	
	public void takedamage (int dor){
		vidasobrando -= dor;
		sliderdevida.value = vidasobrando;
		playerAudio.Play ();
		if (vidasobrando <= 0) {
			helpc = 1;
		}
	}
}
