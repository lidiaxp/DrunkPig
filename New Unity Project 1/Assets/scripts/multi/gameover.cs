using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameover : MonoBehaviour {
	public vida vida;       
	public float restartDelay = 5f; 
	public Image reversewin;
	public Image jackwin;
	public vida2 vida2;

	//Animator anim;                          
	float restartTimer;  
	score ponto;
	score2 ponto2;
	
	void Awake (){
		//anim = GetComponent <Animator> ();
		ponto = FindObjectOfType (typeof(score)) as score;
		ponto2 = FindObjectOfType (typeof(score2)) as score2;
	}
	
	
	void Update (){
		if (vida.vidasobrando <= 0 || vida2.vidasobrando <= 0) {
			if (ponto.pontos > ponto2.pontos2) {
				jackwinner();
			} else if (ponto.pontos < ponto2.pontos2){
				jackreversewinner();
			}else{
				if(vida.vidasobrando <= 0){
					jackreversewinner();
				}
				if(vida2.vidasobrando <= 0){
					jackwinner ();
				}
			}
		}
	}

	void jackreversewinner(){
		//anim.SetTrigger ("gameover");
		reversewin.enabled = true;
		restartTimer += Time.deltaTime;
		Time.timeScale = 0;
		if(Input.GetKey (KeyCode.R)){
			Application.LoadLevel(Application.loadedLevel);
		}
		if(Input.GetKey(KeyCode.Mouse0)){
			Application.LoadLevel("menu");
		}
	}

	void jackwinner(){
		jackwin.enabled = true;
		restartTimer += Time.deltaTime;
		Time.timeScale = 0;
		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}
		if (Input.GetKey (KeyCode.Mouse0)) {
			Application.LoadLevel ("menu");
		}
	}
}
