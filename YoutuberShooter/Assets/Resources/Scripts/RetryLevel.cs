using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryLevel : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("Game 1");
    }

	public void Retry2()
	{
		SceneManager.LoadScene("Game 2");
	}

	public void LoadMain()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
