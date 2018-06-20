using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class andar5 : MonoBehaviour {
	int pular = 80;

	void Start () {
	
	}

	void Update () {
		//float pular = Input.GetAxis("Jump") * 400.0F;
		//pular *= Time.deltaTime;
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(12f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(-12f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(0,0,2f * Time.deltaTime);
			transform.Rotate(0,75f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0,0,-2f * Time.deltaTime);
			transform.Rotate(0,-75f * Time.deltaTime,0);
		}
		if (Physics.Raycast(transform.position, -Vector3.up, 2)) {
			if (Input.GetKeyDown (KeyCode.B)) {
			transform.Translate (0, 4, 0);
			}
		}
	}
}
