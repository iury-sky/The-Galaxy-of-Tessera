using UnityEngine;
using System.Collections;

public class atacar : MonoBehaviour {
	[SerializeField]Animator enemy;
	public static int vida = 15;
	bool podeAtacar, ataque;
	// Update is called once per frame
	void Update () {
	
		if(podeAtacar)
			ataque = true;

		else if(!podeAtacar)
			ataque = false;

		enemy.SetBool("Atack", ataque);
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player"){
			podeAtacar = true;
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			podeAtacar = false;
		}
	}
}
