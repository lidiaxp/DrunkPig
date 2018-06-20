using UnityEngine;
using System.Collections;

public class andar3 : MonoBehaviour {

	void Start () {
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(2f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(-2f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			//transform.Translate(0,0,0.7f * Time.deltaTime);
			transform.Rotate(0,65f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			//transform.Translate(0,0,-1f * Time.deltaTime);
			transform.Rotate(0,-65f * Time.deltaTime,0);
		}
		/*if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,-75f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,75f * Time.deltaTime,0);
		}*/
		if (Physics.Raycast(transform.position, -Vector3.up, 10)) {
			if (Input.GetKeyDown (KeyCode.B)) {
				transform.Translate (0, 1.1f, 0);
			}
		}
	}
}
