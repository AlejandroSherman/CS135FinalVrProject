using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	// Start is called before the first frame update
	int key_count = 1;

	public void AddKey()
	{
		key_count++;
	}

	public void SubtractKey()
	{
		key_count--;
	}

	public int GetKeyAmount()
	{
		return key_count;
	}
}
