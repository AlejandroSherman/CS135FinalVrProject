using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
	public GameObject blueMemorySphere, greenMemorySphere, stoneMemorySphere;

    public Light blueLight;

    void onTriggerEnter(Collider other){
        Debug.Log("On Trigger Enter Activated");

    	// if (other.transform.name == "GreenBlock"){
    	// 	greenMemorySphere.tag = "finished";
     //        Debug.Log("Green Block Entered");
    	// } else if (other.transform.name == "BlueBlock"){
     //        blueMemorySphere.tag = "finished";
     //        Debug.Log("Blue Block Entered");
     //        blueLight.range = 70;
     //    } else if (other.transform.name == "StoneBlock"){
     //        stoneMemorySphere.tag = "finished";
     //        Debug.Log("Stone Block Entered");
     //   }
    }

    // void onTriggerExit(Collider other){
    // 	if (other.transform.name == "GreenBlock"){
    // 		greenMemorySphere.tag = "not finished";
    //         Debug.Log("Green Block Exited");
    // 	} else if (other.transform.name == "BlueBlock"){
    //         blueMemorySphere.tag = "not finished";
    //         Debug.Log("Blue Block Exited");
    //     } else if (other.transform.name == "StoneBlock"){
    //         stoneMemorySphere.tag = "not finished";
    //         Debug.Log("Stone Block Exited");
    //     }
    // }
}
