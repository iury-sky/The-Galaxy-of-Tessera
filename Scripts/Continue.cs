using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Continue : MonoBehaviour {
	[SerializeField]
	GameObject player, saida;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "sair")
		{
			SceneManager.LoadScene ("Continue");
		}
	}
}
