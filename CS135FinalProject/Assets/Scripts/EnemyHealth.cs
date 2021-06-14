using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
	public float health;
	public float maxHealth;
	public GameObject HealthBarUI;
	public Slider slider;

	EnemyController controller;
	// Start is called before the first frame update
	void Start()
	{
		controller = GetComponent<EnemyController>();
		slider = GetComponentInChildren<Slider>();
		health = maxHealth;
		slider.value = CalculateHP();
		HealthBarUI.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		slider.value = CalculateHP();
		if (health < maxHealth)
		{
			HealthBarUI.SetActive(true);
		}
		if (health <= 0)
		{
			HealthBarUI.SetActive(false);
			controller.Die();
		}
		if (health > maxHealth)
		{
			health = maxHealth;

		}
	}

	float CalculateHP()
	{
		return health / maxHealth;
	}
}
