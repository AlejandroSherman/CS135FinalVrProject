using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaycast : MonoBehaviour
{
	[SerializeField] int rayLength = 3;
	[SerializeField] LayerMask layerMaskInteract;
	[SerializeField] string excludeLayerName = null;
	private DoorController raycastedObj;
	[SerializeField] KeyCode openDoorkey = KeyCode.E;
	bool doOnce;
	const string doorTag = "Door";
	PlayerInventory player_inventory;
	void Start()
	{
		GameObject player_obj = GameObject.FindWithTag("Player");
		if (player_obj != null)
		{
			player_inventory = player_obj.GetComponent<PlayerInventory>();
		}
	}

	// Update is called once per frame
	void Update()
	{
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

		if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
		{
			if (hit.collider.CompareTag(doorTag))
			{
				if (!doOnce)
				{
					raycastedObj = hit.collider.gameObject.GetComponent<DoorController>();
				}
			}
			doOnce = true;
			// print("works");
			if (Input.GetKeyDown(openDoorkey))
			{
				if (player_inventory.GetKeyAmount() > 0)
				{
					raycastedObj.OpenDoor();
					player_inventory.SubtractKey();
				}
			}
		}
		else
		{
			doOnce = false;
		}

	}
}
