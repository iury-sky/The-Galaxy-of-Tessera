using UnityEngine;using UnityEngine.UI;
using System.Collections;

public class canvas : MonoBehaviour {

	[SerializeField]Text bSim, bNao, desejaJogar;
    public static bool podeAndar;

    // Update is called once per frame
    void Update() {



        if (Input.GetKeyDown(KeyCode.Y)) { 
            podeAndar = true;
            bSim.text = "";
            bNao.text = "";
            desejaJogar.text = "";

        }
        if (Input.GetKeyDown(KeyCode.N) && !podeAndar)
        {
            Application.LoadLevel("GameOver");
        }
    }

}
