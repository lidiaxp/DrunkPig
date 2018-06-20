using UnityEngine;
using System.Collections;

public class andar7 : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (-18f * Time.deltaTime, 0, 0);
		}
		if (transform.position.x > -995) {
			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.Translate (18f * Time.deltaTime, 0, 0);
			}
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (0, 0, -9f * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0, 0, 9f * Time.deltaTime);
		}
		if (Physics.Raycast (transform.position, -Vector3.up, 2)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.Translate (0, 7, 0);	
				transform.Translate (-3f, 0, 0);
			}
		}
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,-18 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,18 * Time.deltaTime,0);
		}
	}
}
