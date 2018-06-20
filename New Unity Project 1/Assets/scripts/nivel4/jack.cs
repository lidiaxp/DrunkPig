using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class jack : MonoBehaviour {

	public Image bebum;

	void Start () {

	}
	
	void Update () {
		if((int)Time.timeSinceLevelLoad % 2==0){//parada das bolinhas na tela
			bebum.enabled = false;
		}else{
			bebum.enabled = true;
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(35f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(-35f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate(0,45f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(0,-45f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,65f * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,-65f * Time.deltaTime,0);
		}
		if (Physics.Raycast(transform.position, -Vector3.up, 10)) {
			if (Input.GetKeyDown (KeyCode.B)) {
				transform.Translate (0, 45, 0);
			}
		}
	}
}
