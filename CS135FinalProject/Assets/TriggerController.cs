using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TriggerController : MonoBehaviour
{
	public TextMeshProUGUI win_text;
	void OnTriggerEnter(Collider other)
	{
		win_text.enabled = true;
		FindObjectOfType<SoundManager>().Play("WinSound");
		Invoke("LoadLevelSelector", 5f);
	}

	void LoadLevelSelector()
	{
		SceneManager.LoadScene("LevelSelectorMenu");
	}
}
