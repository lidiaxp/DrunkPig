using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class garrafas : MonoBehaviour {
	agua aguaa;
	public Slider nivelgarrafa;

	void Awake (){
		aguaa = FindObjectOfType (typeof(agua)) as agua;
	}

	void Update (){
		nivelgarrafa.value = aguaa.water;
	}
}
