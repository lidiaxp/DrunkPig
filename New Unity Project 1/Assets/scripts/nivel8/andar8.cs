using UnityEngine;
using System.Collections;

public class andar8 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-40f * Time.deltaTime,0,0);
		}
		if(transform.position.x > -1113){
			if(Input.GetKey(KeyCode.DownArrow)){
				transform.Translate(40f * Time.deltaTime,0,0);
			}
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,-45 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,45 * Time.deltaTime,0);
		}
	}
}
