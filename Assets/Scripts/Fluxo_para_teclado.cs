using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_teclado : MonoBehaviour {
	public void CarregarTeclado(){
		SceneManager.LoadScene ("teclado");
	}
}
