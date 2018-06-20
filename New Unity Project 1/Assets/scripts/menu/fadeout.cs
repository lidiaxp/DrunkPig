using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fadeout : MonoBehaviour {
	public Image Image;
	public float flashSpeed = 0.7f;

	static int iniciar = 0;
	int time;
	int timer;
	int q = 0;

	void Start () {
		if (iniciar == 1) {
			Image.enabled = false;
		}
		time = (int)Time.timeSinceLevelLoad + 6;
		timer = (int)Time.timeSinceLevelLoad + 10;
	}

	void Update () {
		if((int)Time.timeSinceLevelLoad > time){
			Image.color = Color.Lerp (Image.color, Color.clear, flashSpeed * Time.deltaTime);
			iniciar = 1;
			q = 1;
		}
		if(q == 1){
			if(Time.timeSinceLevelLoad > timer){
				Image.enabled = false;
			}
		}
	}
}
