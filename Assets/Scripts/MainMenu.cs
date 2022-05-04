using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	LevelLoader loader;

    private void Start()
    {
		loader = FindObjectOfType<LevelLoader>();
    }

    public void PlayGame()
	{
		loader.LoadNextLevel();
	}

	public void QuitGame()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
