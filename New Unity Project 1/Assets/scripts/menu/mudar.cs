using UnityEngine;
using System.Collections;

public class mudar : MonoBehaviour {
	void Start () {

	}

	void Update () {

	}

	public void muda(string level){
		Application.LoadLevel(level);
	}

	public void sair(){
		Application.Quit ();
	}
}
