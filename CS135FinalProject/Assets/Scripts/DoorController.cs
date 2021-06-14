using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	Animator animator;
	Transform left_door;
	Transform right_door;

	private bool IsOpen = false;

	// Start is called before the first frame update
	void Awake()
	{
		animator = GetComponent<Animator>();
		left_door = this.transform.Find("Door_Left");
		right_door = this.transform.Find("Door_Right");
	}


	public void OpenDoor()
	{
		if (!IsOpen)
		{
			animator.Play("OpenDoor");
			FindObjectOfType<SoundManager>().Play("DoorOpen");

			// After 0.5 seconds
			// disable the left and right door mesh render and mesh collider 
			// or disable the entire thing
			Invoke("DisableLeftandRightDoors", 0.7f);//this will happen after 0.7 seconds
													 // left_door.gameObject.SetActive(false);
													 // right_door.gameObject.SetActive(false);
			IsOpen = true;
		}
		else
		{
			IsOpen = false;
		}

	}

	void DisableLeftandRightDoors()
	{
		left_door.gameObject.SetActive(false);
		right_door.gameObject.SetActive(false);
	}
}
