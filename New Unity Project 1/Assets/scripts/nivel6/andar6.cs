using UnityEngine;
using System.Collections;

public class andar6 : MonoBehaviour {
	pontuaçao points;

	void Start () {
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
	}

	void Update () {
		float pular = Input.GetAxis("Jump") * 230.0F;
		pular *= Time.deltaTime;

		if (transform.position.z > -42) {
			transform.Translate (-14f * Time.deltaTime, 0, 0);
		} else {
			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.Translate(-14f * Time.deltaTime ,0,0);
			}
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(0,0,-8f * Time.deltaTime);
			transform.Rotate(0,-6f * Time.deltaTime,0);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(0,0,8f * Time.deltaTime);
			transform.Rotate(0,6f * Time.deltaTime,0);
		}

		if (transform.position.z > 85) {
			if (Input.GetKey(KeyCode.Space)) {
				if (Physics.Raycast (transform.position, -Vector3.up, 1.5F)) {
					transform.Translate (0, 5.5f, 0);
					transform.Translate (-1f, 0, 0);
				}	
			}
		} else {
			if (Input.GetKey(KeyCode.Space)) {
				if (Physics.Raycast (transform.position, -Vector3.up, 1.5F)) {
					transform.Translate (0, 30f * Time.deltaTime, 0);
					transform.Translate (-30f * Time.deltaTime, 0, 0);
				}	
			}
		}


		if(Input.GetKey(KeyCode.E)){
			transform.Rotate(0,-35 * Time.deltaTime,0);
		}

		if(Input.GetKey(KeyCode.R)){
			transform.Rotate(0,35 * Time.deltaTime,0);
		}
	}
}
