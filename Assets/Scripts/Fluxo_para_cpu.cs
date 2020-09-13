using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_cpu : MonoBehaviour {
	public void CarregarCPU(){
		SceneManager.LoadScene ("cpu");
	}
}