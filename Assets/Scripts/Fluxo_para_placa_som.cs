using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_placa_som : MonoBehaviour {
	public void CarregarPlacaSom(){
		SceneManager.LoadScene ("placa_som");
	}
}