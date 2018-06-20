using UnityEngine;
using System.Collections;

public class crazycam : MonoBehaviour {
	public GameObject jack;
	
	void Start () {
	
	}

	void Update () {
		transform.Rotate (0, 0, 0);  //parada da camera
		if (Time.timeSinceLevelLoad % 1.2 >= 0 && Time.timeSinceLevelLoad % 1.2 < 0.4) {
			transform.Rotate (0, -0.8f, 0);
		} else if(Time.timeSinceLevelLoad % 1.2 >= 0.4 && Time.timeSinceLevelLoad % 1.2 < 0.8) {
			transform.Rotate (0, 1.6f, 0);
		}else  {
			transform.Rotate (0, -0.8f, 0);
		}
	}
}