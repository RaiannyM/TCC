using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FluxoMenu : MonoBehaviour {
	public void CarregarAmbiente(){
		SceneManager.LoadScene ("ambiente");
	}
}