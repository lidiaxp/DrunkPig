using UnityEngine;
using System.Collections;

public class controleplayer2 : MonoBehaviour {
	
	void Start () {
		
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.W)){
			transform.Translate(-10f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(8f * Time.deltaTime,0,0);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(0,0,-6f * Time.deltaTime);
			transform.Rotate(0,-30 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(0,0,6f * Time.deltaTime);
			transform.Rotate(0,30 * Time.deltaTime,0);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			if(transform.position.y < 10){
				transform.Translate(0,10,0);
			}
		}
	}
}
