using UnityEngine;
using System.Collections;

public class swichtCamera : MonoBehaviour {
	public Camera[] cameras;

	[SerializeField]
	GameObject exit;

	// Use this for initialization
	void Start () {
		cameras [0].enabled = false;
		cameras [1].enabled = false;
		cameras [2].enabled = false;
		cameras [3].enabled = false;
		cameras [4].enabled = false;
		cameras [5].enabled = false;
		cameras [6].enabled = true;

	}
		
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerExit (Collider outro) 
	{
		if (outro.gameObject.tag == "exit1") {
			if (cameras [0].enabled == true)
				cameras [0].enabled = false;
			else if (cameras [0].enabled == false)
				cameras [0].enabled = true;
			if (cameras [7].enabled == true)
				cameras [7].enabled = false;
			else if (cameras [7].enabled == false)
				cameras [7].enabled = true;

		}
		if (outro.gameObject.tag == "exit2") {
			if(cameras[1].enabled == true)
				cameras[1].enabled = false;
			else if(cameras[1].enabled == false)
				cameras[1].enabled = true;
			if(cameras[7].enabled == true)
				cameras[7].enabled = false;
			else if(cameras[7].enabled == false)
				cameras[7].enabled = true;
		}

		if (outro.gameObject.tag == "exit3") {
			if(cameras[2].enabled == true)
				cameras[2].enabled = false;
			else if(cameras[2].enabled == false)
				cameras[2].enabled = true;
			if(cameras[7].enabled == true)
				cameras[7].enabled = false;
			else if(cameras[7].enabled == false)
				cameras[7].enabled = true;
		}
		if (outro.gameObject.tag == "exit4") {
			if(cameras[3].enabled == true)
				cameras[3].enabled = false;
			else if(cameras[3].enabled == false)
				cameras[3].enabled = true;
			if(cameras[7].enabled == true)
				cameras[7].enabled = false;
			else if(cameras[7].enabled == false)
				cameras[7].enabled = true;
		}

		if (outro.gameObject.tag == "exit5") {
			if(cameras[4].enabled == true)
				cameras[4].enabled = false;
			else if(cameras[4].enabled == false)
				cameras[4].enabled = true;
			if(cameras[7].enabled == true)
				cameras[7].enabled = false;
			else if(cameras[7].enabled == false)
				cameras[7].enabled = true;
		}
		if (outro.gameObject.tag == "exit6") {
			if(cameras[5].enabled == true)
				cameras[5].enabled = false;
			else if(cameras[5].enabled == false)
				cameras[5].enabled = true;
			if(cameras[7].enabled == true)
				cameras[7].enabled = false;
			else if(cameras[7].enabled == false)
				cameras[7].enabled = true;
		}

	}
}
