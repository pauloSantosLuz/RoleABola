using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceUsuario : MonoBehaviour
{
	public void Recomecar()
	{
		SceneManager.LoadScene("Jogo");
	}

	public void Sair()
	{
		Application.Quit();
	}
}
