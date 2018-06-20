using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gotinp : MonoBehaviour {
	public int water;
	public Slider pontos;

	void Awake (){
		water = 0;
	}

	void Update (){
		pontos.value = water;
	}
}
