using UnityEngine;
using System.Collections;

public class tiro : MonoBehaviour {

    [SerializeField]
    public Transform tiro1;

	// Use this for initialization
	void Start () {
        tiro1.gameObject.SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (dir != Vector3.zero)
            transform.forward = Vector3.Normalize(dir);
        if (Input.GetKeyDown(KeyCode.LeftControl)) {

            RaycastHit tiro = new RaycastHit();

            if (Physics.Raycast(transform.position, transform.forward, out tiro)) {

                if (tiro.collider.tag == "inimigo") {

                    Instantiate(tiro1, tiro.collider.gameObject.transform.position, Quaternion.identity);
                    tiro.collider.gameObject.SetActive(false);
                    Destroy(GameObject.Find("Sangue(Clone)"), 1.5f);

                }
            }
        }
	
	}
}
