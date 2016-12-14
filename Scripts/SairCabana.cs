using UnityEngine;
using System.Collections;

public class SairCabana : MonoBehaviour {

	[SerializeField]Transform cameraPos;
	[SerializeField]int pos;
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			cameraPos.position = new Vector3 (cameraPos.position.x, cameraPos.position.y, cameraPos.position.z - pos);
		}
	}
}
