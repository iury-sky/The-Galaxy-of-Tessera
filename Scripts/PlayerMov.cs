using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Animator))]
public class PlayerMov : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Vertical")) {
			anim.SetBool ("Andar", true);
		} else {
			anim.SetBool ("Andar", false);

		}
	}
}
