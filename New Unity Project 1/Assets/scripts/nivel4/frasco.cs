using UnityEngine;
using System.Collections;

public class frasco : MonoBehaviour {

	int prafrente = 80;

	void Start () {
	}

	void Update () {
		transform.Translate (0, prafrente * Time.deltaTime, 0);
		if (transform.position.z >= 2200 || transform.position.z <= 1810) {
			prafrente = prafrente * -1;
		}
	}

}
