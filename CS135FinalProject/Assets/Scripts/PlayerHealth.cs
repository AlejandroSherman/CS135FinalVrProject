using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

	public float health = 100;
	public float maxHealth = 100;

	public Slider slider;
	// Start is called before the first frame update
	void Start()
	{
		health = maxHealth;
	}

	// Update is called once per frame
	void Update()
	{
		slider.value = CalculateHP();

		if (health <= 0)
		{
			// player dies
			SceneManager.LoadScene("Zone2");
		}
		if (health > maxHealth)
		{
			health = maxHealth;
		}
	}

	public void TakeDamage(float dmg)
	{
		health -= dmg;
	}

	float CalculateHP()
	{
		return health / maxHealth;
	}
}
