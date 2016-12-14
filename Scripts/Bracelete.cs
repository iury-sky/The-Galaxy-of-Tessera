using UnityEngine;
using System.Collections;

public class Bracelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(8*Time.deltaTime, 15*Time.deltaTime, 5*Time.deltaTime);
	
	}
}
