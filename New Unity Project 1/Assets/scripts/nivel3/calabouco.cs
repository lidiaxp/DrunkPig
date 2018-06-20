using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class calabouco : MonoBehaviour {
	pontos pontos;
	public GameObject chao;
	public Image fim;
	bool pass = false;
	float timetofim;
	float timenofim;
	public int help = 1;
	public GameObject jack;
	public Image inicio;

	andar3 andar3;

	void Start () {
		pontos = FindObjectOfType (typeof(pontos)) as pontos;
		andar3 = jack.GetComponent<andar3> ();
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			if (pontos.ponto >= 25) {
				Destroy (chao);
				pass = true;
				help = 0;
			}
		}
	}

	void Update () {
		if (!inicio.enabled) {
			andar3.enabled = true;
		}
		if (help == 0) {
			timetofim = (int)Time.timeSinceLevelLoad + 3;
			timenofim = (int)Time.timeSinceLevelLoad + 35;
			help = 1;
		}
		if(pass){
			if(timetofim <= Time.timeSinceLevelLoad){
				fim.enabled = true;
				if(timenofim <= Time.timeSinceLevelLoad || Input.GetKey (KeyCode.Mouse0)){
					Application.LoadLevel("nivel4");
				}
			}
		}
	
	}
}
