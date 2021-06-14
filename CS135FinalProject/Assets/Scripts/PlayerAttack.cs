using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	public Camera camera;
	public WeaponController weapon;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PerformAttack();
		}
	}

	void PerformAttack()
	{
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		FindObjectOfType<SoundManager>().Play("SwordSwing");
		if (Physics.Raycast(ray, out hit, weapon.AttackRange))
		{
			if (hit.collider.tag == "Enemy")
			{
				EnemyController enemy = hit.collider.GetComponent<EnemyController>();
				enemy.TakeDamage(weapon.AttackDamage);
			}
		}
	}
}
