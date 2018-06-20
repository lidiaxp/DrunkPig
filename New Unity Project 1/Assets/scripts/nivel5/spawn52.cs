using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawn52 : MonoBehaviour {     
	public GameObject enemy; 
	public float spawnTime = 0.15f;
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {
		
	}

	public void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-37f, 37f), 22f, Random.Range (-12f, 12f));
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (enemy, spawnPosition,spawnRotation);
		}
	}
}
