using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo : MonoBehaviour {
	public void CarregarListaDeCuidados(){
		SceneManager.LoadScene ("lista_de_cuidados");
	}
}

