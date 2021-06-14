using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class KeyCounter : MonoBehaviour
{
	PlayerInventory player_inventory;
	TextMeshProUGUI keyCounterText;

	// Start is called before the first frame update
	void Start()
	{
		keyCounterText = GetComponent<TextMeshProUGUI>();
		GameObject player_obj = GameObject.FindWithTag("Player");
		if (player_obj != null)
		{
			player_inventory = player_obj.GetComponent<PlayerInventory>();
		}
	}

	// Update is called once per frame
	void Update()
	{
		keyCounterText.text = player_inventory.GetKeyAmount().ToString();
	}
}
