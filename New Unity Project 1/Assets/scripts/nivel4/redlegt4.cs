using UnityEngine;
using System.Collections;

public class redlegt4 : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		transform.Translate(-80f * Time.deltaTime,0,0);
		Destroy(gameObject,3);
		if (Physics.Raycast (transform.position, transform.forward, 1)) {
			Destroy (gameObject);
		}
	}
}
