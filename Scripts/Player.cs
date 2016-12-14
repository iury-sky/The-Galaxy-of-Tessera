using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    [SerializeField]
    public static int vida = 25;
    string cena;
    Transform cameraMax;
    bool canRun, canSocar;
    Rigidbody player;
    Animator pAnime;
    float velocidade, girar;
	[SerializeField]
	AudioSource passos, punch;
	[SerializeField]GameObject enm;


    void Awake() {
        transform.tag = "Player";

    }

    void Start()
    {
        player = GetComponent<Rigidbody>();
        pAnime = GetComponent<Animator>();
        velocidade = 10;
        girar = 120;
        cameraMax = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    // Update is called once per frame
    void Update() {

		if(atacar.vida == 0){
			Destroy(enm);
		}


        //float translate = (Input.GetAxis("Horizontal") * velocidade) * Time.deltaTime;
        //float rotate = (Input.GetAxis("Vertical") * girar) * Time.deltaTime;

        //transform.Rotate(0, rotate, 0);
        if (canvas.podeAndar == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, velocidade * Time.deltaTime);
                canRun = true;
				passos.Play();
            }
            else
                canRun = false;


			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (0, 0, -velocidade * Time.deltaTime);
				passos.Play();
			}
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 100 * Time.deltaTime, 0);
				passos.Play();
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -100 * Time.deltaTime, 0);
				passos.Play();
            }

			if(Input.GetButton("Fire1")){
				canSocar = true;
				Debug.Log("Socou");
				punch.Play();
			}
			else
				canSocar = false;

			if(vida == 0){
				Application.LoadLevel("GameOver");
			}

            pAnime.SetBool("run", canRun);
			pAnime.SetBool("socar", canSocar);
        }
    } 
}
