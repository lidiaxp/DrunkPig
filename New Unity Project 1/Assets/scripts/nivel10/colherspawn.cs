using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class colherspawn : MonoBehaviour {
	public GameObject enemy;    
	public float spawnTime = 5f;   
	public Image inicio;
	public int colheres;
	public Image mortemorrida;
	public Image morteconcha;
	public Image teste;
	public Image fim;
	public bool morteconcha1;
	public bool teste1;
	public bool fim1;

	life10 life;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		life = FindObjectOfType (typeof(life10)) as life10;
	}

	void Update () {
		if(morteconcha1){
			if(!mortemorrida.enabled){
				morteconcha.enabled = true;
				life.help = 1;
				morteconcha1 = false;
			}
		}
		if(teste1){
			teste.enabled = true;
			fim.enabled = true;
			teste1 = false;
		}
	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (Random.Range(-604.6f,-525.7f), 15f, Random.Range(475.4f, 527.2f));
			Quaternion spawnRotation = Quaternion.Euler(90,0,0);
			Instantiate (enemy, spawnPosition, spawnRotation);
		}
	}
}
