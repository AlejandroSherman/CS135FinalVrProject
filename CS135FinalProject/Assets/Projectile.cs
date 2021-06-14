using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public Rigidbody projectile;
	public Transform Spawnpoint;
	public List<Rigidbody> projectiles = new List<Rigidbody>();
	private int timer = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer++;
		if(Input.GetMouseButtonDown(0)){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*20);
			Destroy(clone.gameObject, 1);
			Destroy(clone, 1);
		}
	}
}