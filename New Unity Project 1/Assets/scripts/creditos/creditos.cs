using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.UI.Graphic.rectTransform;

public class creditos : MonoBehaviour {

	void Start () {
		Vector3 temp = transform.position; 
		temp.y = -500;
		transform.position = temp;
	}

	void Update () {
		Vector3 temp = transform.position; 
		temp.y += 1.75f; 
		transform.position = temp;
		print (temp.y);
		if (temp.y > 1000) {
			Application.LoadLevel("menu");
		}
	}
}

