using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {

	[SerializeField]Transform playerPos, enemyPos;
	bool seguir, run, rotate;
	[SerializeField]float speed;
	[SerializeField]Animator enemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(seguir){
			enemyPos.transform.position = Vector3.Lerp(enemyPos.transform.position, playerPos.transform.position, Time.deltaTime / speed);
			run = true;
		}

		if(rotate){
			enemyPos.LookAt(playerPos);
		}

		enemy.SetBool("Run", run);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			seguir = true;
			rotate = true;
		}
	}
}
