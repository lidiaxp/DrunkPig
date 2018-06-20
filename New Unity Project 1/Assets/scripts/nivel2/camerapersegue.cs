using UnityEngine;
using System.Collections;

public class camerapersegue : MonoBehaviour {
	public GameObject jack;
	static int vidas = 3;

	void Start () {
	
	}

	void Update () {
		if (jack.transform.position.x > -1310) {
			transform.Translate(0,0,3.4f);
			if (jack.transform.position.x < transform.position.x) {
				Destroy(jack);
				vidas--;
				Application.LoadLevel(Application.loadedLevel);
				if(vidas<=0){
					PlayerPrefs.SetInt ("save", 3);
					Application.LoadLevel("nivel1");
				}
			}
		}
	}
}
