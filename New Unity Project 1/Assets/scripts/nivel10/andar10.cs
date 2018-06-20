using UnityEngine;
using System.Collections;

public class andar10 : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-30f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(30f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,75f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,-75f * Time.deltaTime,0);
		}
		if (Physics.Raycast (transform.position, -Vector3.up, 3)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.Translate (0, 10, 0);	
			}
		}
	}
}
