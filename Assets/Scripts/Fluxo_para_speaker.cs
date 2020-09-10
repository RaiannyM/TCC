using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_speaker : MonoBehaviour {
	public void CarregarSpeaker(){
		SceneManager.LoadScene ("speaker");
	}
}

