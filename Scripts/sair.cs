using UnityEngine;
using System.Collections;

public class sair : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnColliderEnter(Collider other){
		if(other.gameObject.tag == "Player"){

		}
	}
}
