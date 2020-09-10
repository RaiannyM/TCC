using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_gabinete : MonoBehaviour {
	public void CarregarGabinete(){
		SceneManager.LoadScene ("gabinete");
	}
}