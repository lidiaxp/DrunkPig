using UnityEngine;
using System.Collections;

public class data : MonoBehaviour {
	
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);

	}

	void Update () {

	}

	public void save (string oi){
		if (PlayerPrefs.HasKey ("save")) {
			if (oi == "oi") {
				Application.LoadLevel (PlayerPrefs.GetInt("save"));
			}
		} else {
			Application.LoadLevel (3);
		}
	}
}