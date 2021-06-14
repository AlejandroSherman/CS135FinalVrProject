using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balldropscript : MonoBehaviour
{
	public GameObject blueBlock, greenBlock, stoneBlock;
	public Light bluelight, greenlight, stonelight;
    // Start is called before the first frame update
	void OnTriggerEnter(Collider other){
		Debug.Log("Collision detected");
		if (other.name == blueBlock.name){
			Debug.Log("Blue Block Entered");
			bluelight.range = 50;

		} else if (other.name == greenBlock.name){
			Debug.Log("Green Block Entered");
			greenlight.range = 50;

		} else if (other.name == stoneBlock.name){
			Debug.Log("Stone Block Entered");
			stonelight.range = 50;

		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == blueBlock.name){
			Debug.Log("Blue Block Exited");
			bluelight.range = 0;

		} else if (other.name == greenBlock.name){
			Debug.Log("Green Block Exited");
			greenlight.range = 0;


		} else if (other.name == stoneBlock.name){
			Debug.Log("Stone Block Exited");
			stonelight.range = 0;
		}
	}
}
