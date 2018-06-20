using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tfactory : MonoBehaviour {
	pontuaçao points;
	public Slider factory;

	void Start () {
		points = FindObjectOfType (typeof(pontuaçao)) as pontuaçao;
	}

	void Update () {
		factory.value = points.fabricas;
	}
}
