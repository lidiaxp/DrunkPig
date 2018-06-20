using UnityEngine;
using System.Collections;

public class andar9 : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
		if(transform.position.x > -228){
			if(Input.GetKey(KeyCode.UpArrow)){
				transform.Translate(-30f * Time.deltaTime,0,0);
			}
		}
		if(transform.position.x < -90){
			if(Input.GetKey(KeyCode.DownArrow)){
				transform.Translate(30f * Time.deltaTime,0,0);
			}
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,65f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,-65f * Time.deltaTime,0);
		}
		if (Physics.Raycast (transform.position, -Vector3.up, 3)) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				transform.Translate (0, 5, 0);	
			}
		}
	}
}
