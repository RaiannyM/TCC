﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Fluxo_para_lista_de_cuidados : MonoBehaviour {
	public void CarregarListaDeCuidados(){
		SceneManager.LoadScene ("lista_de_cuidados");
	}
}

