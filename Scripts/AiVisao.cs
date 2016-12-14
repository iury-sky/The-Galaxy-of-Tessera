using UnityEngine;
using System.Collections;

public class AiVisao : MonoBehaviour {

    private float campo;
    [SerializeField]
    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        campo = Vector3.Distance(transform.position,player.position);

        if (campo < 20){
            olhar();

        }

        if (campo < 10) {
            seguir();
            olhar();
        }
	
	}
    void olhar() {
        Quaternion visao;

        visao = Quaternion.LookRotation(player.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, visao, 7f * Time.deltaTime);
    
    }
    void seguir() {
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);

    }
}
