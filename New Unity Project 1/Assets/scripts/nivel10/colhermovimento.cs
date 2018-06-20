using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class colhermovimento : MonoBehaviour {
	public Image inicio;

	int help = 0;
	int time = 0;
	bool can = false;

	colherspawn colhera;

	void Start () {
		colhera = FindObjectOfType (typeof(colherspawn)) as colherspawn;
		colhera.colheres += 1;
	}

	void Update () {
		if(!inicio.enabled){
			if(help == 1){                             //espera 3 segundos
				time = (int)Time.timeSinceLevelLoad + 3;
				help = 0;
			}
			//-------------------------------------------------------------
			if (transform.position.y > -74.8 && !can) {
				transform.Translate (0, 0, 40 * Time.deltaTime);
			}
			if (transform.position.y <= -69 && transform.position.y >= -70) {
				help = 1;
			}
			if(transform.position.y <= -74.5){
				can = true;
			}
			if(can){  
				if(time <= (int)Time.timeSinceLevelLoad){
					transform.Translate (0, 0, -40 * Time.deltaTime);
				}
			}
			//--------------------------------------------------------------
			if(transform.position.y > 20){
				Destroy (gameObject);
			}
		}
	}
}
