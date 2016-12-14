using UnityEngine;
using System.Collections;

public class matarInimigo : MonoBehaviour {

	GameObject enm1, enm2;
	bool ennm1, ennm2;
	// Use this for initialization
	void Start () {
	
		enm1 = GameObject.FindGameObjectWithTag("inimigo1");
		enm2 = GameObject.FindGameObjectWithTag("inimigo2");
	}
	
	// Update is called once per frame
	void Update () {
	
		if(atacar.vida == 0 && ennm1){
			Destroy(enm1);
		}

		if(atacar.vida == 0 && ennm2){
			Destroy(enm2);
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "inimigo1"){
			atacar.vida -=1;
			ennm1 = true;
			Debug.Log(atacar.vida);
		}

		if(other.tag == "inimigo2"){
			atacar.vida -=1;
			ennm2 = true;
			Debug.Log(atacar.vida);
		}
	}
}
