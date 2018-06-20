using UnityEngine;
using System.Collections;

public class movimento : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-25f * Time.deltaTime,0,0);
		}
		if(transform.position.x > -950){
			if(Input.GetKey(KeyCode.DownArrow)){
				transform.Translate(25f * Time.deltaTime,0,0);
			}
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(0,0,-10f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0,0,10f * Time.deltaTime);
		}
		if (Physics.Raycast (transform.position, -Vector3.up, 3)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.Translate (0, 5.5f, 0);	
			}
		}
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,-70 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,70 * Time.deltaTime,0);
		}
		if (transform.position.y < 60 || transform.position.y > 105) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
