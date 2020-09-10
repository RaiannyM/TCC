using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_impressora : MonoBehaviour {
	public void CarregarImpressora(){
		SceneManager.LoadScene ("impressora");
	}
}
