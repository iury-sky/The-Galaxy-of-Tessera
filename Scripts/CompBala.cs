using UnityEngine;
using System.Collections;

public class CompBala : MonoBehaviour {

    [SerializeField]
    public Rigidbody rb;
    [SerializeField]
    public Collider myCollider;

	// Use this for initialization
	void Start () {
        GameObject player;
        player = GameObject.Find("Graphics");
        rb = GetComponent<Rigidbody>();

        rb.AddForce(player.transform.forward * 2000);

        myCollider = gameObject.GetComponent<Collider>();
	
	}
	
	// Update is called once per frame
	void Update () {

        Destroy(gameObject, 1f);

	}
    /*void OnTriggerEnter(Collider outro)
    {

        if (outro.gameObject.tag == "inimigo")
        {
            Destroy(outro.gameObject);
        }
    }*/

}
