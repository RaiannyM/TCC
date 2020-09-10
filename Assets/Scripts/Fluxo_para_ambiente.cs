using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_ambiente : MonoBehaviour {
	public void CarregarAmbiente(){
		SceneManager.LoadScene ("ambiente");
	}
}
