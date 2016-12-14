using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

    [SerializeField]
    public Transform bala;
    //public float charge;

	// Use this for initialization
	void Start () {
        //charge = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (dir != Vector3.zero) {

            transform.forward = Vector3.Normalize(dir);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl)) {

            Instantiate(bala, transform.position, Quaternion.identity);
 
        }
            

    /*
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
         RaycastHit tiro = new RaycastHit();
         if (Physics.Raycast(transform.position, transform.forward, out tiro)) {

             if (tiro.collider.tag == "inimigo") {

                 Instantiate(ponto, tiro.collider.gameObject.transform.position, Quaternion.identity);
                 tiro.collider.gameObject.SetActive(false);
                 Destroy(GameObject.Find("Sangue(Clone)"), 0.5f);
             }
 
         }

        }
     */ 
	}
}
