using UnityEngine;
using System.Collections;
[RequireComponent(typeof(NavMeshAgent))]

public class InimPA : MonoBehaviour {

    private GameObject player;
    private NavMeshAgent navMesh;
    private bool podeAtacar;

    private float campo;//
    [SerializeField]//
    public Transform Player;//

	void Start () {
        
        player = GameObject.FindWithTag("Player");
        navMesh = GetComponent<NavMeshAgent>();
        podeAtacar = true;
	}
	
	void Update () {
        navMesh.destination = player.transform.position;
        if (Vector3.Distance(transform.position, player.transform.position) < 0.01f) {
            Atacar();
        }
        

        campo = Vector3.Distance(transform.position, Player.position);

        if (campo < 20)
        {
            olhar();

        }

        if (campo < 10)
        {
            seguir();
            olhar();
        }
	
	}

    void Atacar() {
        if (podeAtacar == true) {
            StartCoroutine("TempoDeAtaque");
            //player.GetComponent<Player>().vida-=2;
        }
    }
    IEnumerator TempoDeAtaque() {
        podeAtacar = false;
        yield return new WaitForSeconds (2);
        podeAtacar = true;
    }

    void olhar()
    {
        Quaternion visao;

        visao = Quaternion.LookRotation(Player.position - transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, visao, 7f * Time.deltaTime);

    }
    void seguir()
    {
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);

    }
}
