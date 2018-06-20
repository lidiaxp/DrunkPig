using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnaviao : MonoBehaviour {
	public GameObject airplane;    
	public float spawnTime = 2.3f;   
	public Image inicio;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Update () {

	}

	void Spawn(){
		if (!inicio.enabled) {
			Vector3 spawnPosition = new Vector3 (-748.8f, Random.Range(6f,8.39f), Random.Range(17.79f,29.36f));
			Quaternion spawnRotation = Quaternion.Euler(270,180,0);
			Instantiate (airplane, spawnPosition, spawnRotation);
		}
	}
}
