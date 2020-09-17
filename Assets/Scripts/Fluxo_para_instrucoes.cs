using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_instrucoes : MonoBehaviour {
	public void CarregarInstrucoes(){
		SceneManager.LoadScene ("instrucoes");
	}
}