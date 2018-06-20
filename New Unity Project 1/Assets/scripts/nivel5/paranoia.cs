using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class paranoia : MonoBehaviour {
	public Image bebum;
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject five;
	public GameObject six;

	BoxCollider box1;
	BoxCollider box2;
	BoxCollider box3;
	BoxCollider box4;
	BoxCollider box5;
	BoxCollider box6;

	void Start () {
		box1 = one.GetComponent<BoxCollider> ();
		box2 = two.GetComponent<BoxCollider> ();
		box3 = three.GetComponent<BoxCollider> ();
		box4 = four.GetComponent<BoxCollider> ();
		box5 = five.GetComponent<BoxCollider> ();
		box6 = six.GetComponent<BoxCollider> ();
	}

	void Update () {
		if((int)Time.timeSinceLevelLoad % 2 == 0){//parada das bolinhas na tela
			bebum.enabled = false;
		}else{
			bebum.enabled = true;
		}

		transform.Rotate (0, 0, 0);  //parada da camera
		if (Time.timeSinceLevelLoad % 3 >= 0 && Time.timeSinceLevelLoad % 3 < 1) {
			transform.Rotate (0, -0.4f, 0);
		} else if(Time.timeSinceLevelLoad % 3 >= 1 && Time.timeSinceLevelLoad % 3 < 2) {
			transform.Rotate (0, 0.8f, 0);
		}else  {
			transform.Rotate (0, -0.4f, 0);
		}

		if((int)Time.timeSinceLevelLoad%2==0){//parada das paredes
			box1.enabled = true;
			box2.enabled = false;
			box3.enabled = true;
			box4.enabled = false;
			box5.enabled = true;
			box6.enabled = false;
		}else{
			box1.enabled = false;
			box2.enabled = true;
			box3.enabled = false;
			box4.enabled = true;
			box5.enabled = false;
			box6.enabled = true;
		}
	}
}
