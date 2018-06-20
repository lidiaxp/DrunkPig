using UnityEngine;
using System.Collections;

public class queda : MonoBehaviour {
	
	public Transform Player;
	private float Ultimaposicaoemy, Distanciadequeda;
	public float Distanciamaximadequeda = 150, Danopormetro = 1;
	life4 life4;

	void Start () {
		life4 = GetComponent <life4> ();
	}

	void Update () {
		if (Ultimaposicaoemy > Player.transform.position.y ) {
			Distanciadequeda += Ultimaposicaoemy - Player.transform.position.y;
		}
		Ultimaposicaoemy = Player.transform.position.y;
		if (Distanciadequeda >= Distanciamaximadequeda && Physics.Raycast(transform.position, -Vector3.up, 10) ) {
			if(Physics.Raycast(transform.position, -Vector3.up, 10)){
				life4.takedamage((int)Danopormetro*(int)Distanciadequeda);
			}

			zerarvariaveis();
		}
	}

	void zerarvariaveis(){
		Distanciadequeda = 0;
	}
}
