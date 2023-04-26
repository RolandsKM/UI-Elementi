using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ainaParsledzejs : MonoBehaviour {

	public void uzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);

	}
	public void Atpakal()
	{
		Application.Quit();
	}
    public void uzUI()
    {
        SceneManager.LoadScene("UI-elementi", LoadSceneMode.Single);

    }

}
