﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Click () {
		SceneManager.LoadScene("Lv1");
	}
}
