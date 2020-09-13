using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_memoria_ram : MonoBehaviour {
	public void CarregarMemoriaRAM(){
		SceneManager.LoadScene ("memoria_ram");
	}
}
