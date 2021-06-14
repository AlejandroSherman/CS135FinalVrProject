using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	// Loading scenes by build index
	public void PlayLevel1()
	{
		SceneManager.LoadScene("Zone1");
	}

	public void LoadZone2Instructions()
	{
		SceneManager.LoadScene("Zone2 Instructions");
	}

	public void PlayLevel2()
	{
		SceneManager.LoadScene("Zone2");
	}
	public void LoadZone2WinScreen()
	{
		SceneManager.LoadScene("Zone2 Win Screen");
	}

	public void PlayLevel3()
	{
		SceneManager.LoadScene("Zone3");
	}
	public void QuitGame()
	{
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
		Application.Quit();
        #endif
	}
}
