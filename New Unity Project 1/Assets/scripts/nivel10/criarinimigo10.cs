using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class criarinimigo10 : MonoBehaviour {

	public GameObject enemy;    
	public float spawnTime = 3f;   
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {

	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (Random.Range(-600f,-521f), -73.4f, Random.Range(460f, 542f));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (enemy, spawnPosition, spawnRotation);
		}
	}
}
