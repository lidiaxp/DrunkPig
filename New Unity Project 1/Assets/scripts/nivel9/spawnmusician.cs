using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnmusician : MonoBehaviour {
	public GameObject Chefao;
	public Slider sliderdevida;
	public Image sliderp1;
	public Image sliderp2;
	public Image sliderp3;
	public Image fim;
	public Image teste;

	public int ponto;
	public int chefao;

	public int vidasobrando;
	public bool death;
	public bool help;

	void Start () {
		ponto = 0;
		chefao = 0;
	}

	void Update () {
		if(chefao > 1){
			sliderdevida.value = vidasobrando;
			if(death && !help){
				fim.enabled = true;
				teste.enabled = true;
			}
		}
		if(ponto >= 25 && chefao == 0){
			chefao = 1;
		}
		if(chefao == 1){
			Vector3 posicao = new Vector3 (-223f, -11.9f, 4.6f);
			Quaternion rotacao = Quaternion.Euler (0, 90, 0);
			Instantiate (Chefao, posicao, rotacao);
			sliderp1.enabled = true;
			sliderp2.enabled = true;
			sliderp3.enabled = true;
			chefao = 2;
		}
	}
}
