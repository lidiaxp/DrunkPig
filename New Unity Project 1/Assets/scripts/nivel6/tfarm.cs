using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tfarm : MonoBehaviour {
	public Slider farm;
	pontuaçao points;

	void Start () {
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
	}

	void Update () {
		farm.value = points.fazendas;
	}
}
