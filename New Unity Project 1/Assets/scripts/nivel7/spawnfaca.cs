using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnfaca : MonoBehaviour {
	public GameObject knife;    
	public float spawnTime = 0.5f;   
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {

	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (-1002.9f, Random.Range(1.69f,7.9f), Random.Range(16.86f,31.12f));
			Quaternion spawnRotation = Quaternion.Euler(90,0,0);
			Instantiate (knife, spawnPosition, spawnRotation);
		}
	}
}
