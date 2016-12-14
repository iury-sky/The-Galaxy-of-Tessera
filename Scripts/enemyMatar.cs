using UnityEngine;
using System.Collections;

public class enemyMatar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider outro) {
		
		if (outro.gameObject.tag == "Player"){
			Player.vida -=1;
			Debug.Log(Player.vida);
		}
	}
}
