using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
	EnemyHealth enemy_health;

	public float LookRadius = 10f;
	public float EnemyDamage = 10f;

	Transform player;
	NavMeshAgent agent;
	Animator animator;
	SphereCollider collider;

	PlayerInventory player_inventory;
	PlayerHealth player_health;

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.Find("FPSController").transform;
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
		collider = GetComponent<SphereCollider>();
		enemy_health = GetComponent<EnemyHealth>();
		GameObject player_obj = GameObject.FindWithTag("Player");
		if (player_obj != null)
		{
			player_inventory = player_obj.GetComponent<PlayerInventory>();
			player_health = player_obj.GetComponent<PlayerHealth>();
		}
	}

	// Update is called once per frame
	void Update()
	{
		float distance = Vector3.Distance(player.position, transform.position);
		if (distance <= LookRadius)
		{
			agent.SetDestination(player.position);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		AttackPlayer();
	}
	public void AttackPlayer()
	{
		animator.Play("Attack03");
		player_health.TakeDamage(EnemyDamage);
	}

	public void TakeDamage(float amount)
	{
		enemy_health.health -= amount;
		animator.Play("GetHit");
		FindObjectOfType<SoundManager>().Play("EnemyHurt");
		print("Enemy Hp:" + enemy_health.health);

		if (IsDead())
		{
			if (player_inventory != null)
			{
				player_inventory.AddKey();
				// print(player_inventory.GetKeyAmount());
			}
		}
	}
	bool IsDead()
	{
		return enemy_health.health <= 0;
	}

	public void Die()
	{
		// play death animation and drop key
		animator.Play("Die");
		// TODO: add delay to destroy so the animation can actually play
		// Drop a key or add a key to the player UI
		// Destroy(this.gameObject);
		// print("Dead");

		// Stop the navMeshAgent
		agent.isStopped = true;
		// Disable collider after death
		collider.enabled = false;


		//Remove the AI script (the enemy is dead now)
		// Destroy(this);
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, LookRadius);
	}
}
