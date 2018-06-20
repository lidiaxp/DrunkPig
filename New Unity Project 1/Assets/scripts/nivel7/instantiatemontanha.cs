using UnityEngine;
using System.Collections;

public class instantiatemontanha : MonoBehaviour {
	public GameObject mountain;
	float[] lugares = {-981f,-957f,-933f,-909f,-885f,-861f,-837f,-813f,-789f,-765f};
	int help = 0;

	void Start () {
		
	}

	void Update () {
		if(help == 0){
			for(int x = 0; x < lugares.Length; x++){
				Vector3 spawnPosition = new Vector3 (lugares[x], Random.Range(-3.6f,-1.3f), 23.9f);
				Instantiate (mountain, spawnPosition, transform.rotation);
			}
			help = 1;
		}
	}
}
