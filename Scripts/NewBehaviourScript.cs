using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    [SerializeField]
    public int vida;
    [SerializeField]
    public int speed;
    
    private float angulo;

	// Use this for initialization
	void Start () {

        vida = 5;
        speed = 1;
        angulo = 90;

	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit = new RaycastHit();
        RaycastHit hit2 = new RaycastHit();
        //chao
        if (Physics.Raycast(transform.position, -Vector3.up, out hit ,1f))
        {
            speed = speed;
            angulo = angulo;
        }
        else
        {
            speed = speed * -1;
            angulo = angulo * -1;
        }
        //parede
        if (!Physics.Raycast(transform.position, transform.forward, out hit2, 1f))
        {
            speed = speed;
            angulo = angulo;
        }
        else
        {
            speed = speed * -1;
            angulo = angulo * -1;
        }

        if (vida < 1)
            gameObject.SetActive(false);

        transform.eulerAngles = new Vector3(0, angulo, 0);
        transform.position += new Vector3(speed, 0, 0)*Time.deltaTime;
   
	}
    
        void OnTriggerEnter(Collider outro) {

            if (outro.gameObject.tag == "bala")
              vida -= 1;
    
    }
}
