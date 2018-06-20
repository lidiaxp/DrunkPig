using UnityEngine;
using System.Collections;

public class controleplayer : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(-10f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(8f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(0,0,-6f * Time.deltaTime);
			transform.Rotate(0,-30 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0,0,6f * Time.deltaTime);
			transform.Rotate(0,30 * Time.deltaTime,0);
		}
		if(Input.GetKeyDown(KeyCode.J)){
			if(transform.position.y < 10){
				transform.Translate(0,10,0);
			}
		}
	}
}
