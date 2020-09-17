using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_situacao_problema : MonoBehaviour {
	public void CarregarSituacaoProblema(){
		SceneManager.LoadScene ("situacao_problema");
	}
}
