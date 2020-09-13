using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_placa_mae : MonoBehaviour {
	public void CarregarPlacaMae(){
		SceneManager.LoadScene ("placa_mae");
	}
}
