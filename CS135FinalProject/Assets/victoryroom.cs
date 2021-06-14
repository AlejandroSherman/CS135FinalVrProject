using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victoryroom : MonoBehaviour
{
	public Light bluelight, greenlight, stonelight;

    // Update is called once per frame
    void Update()
    {
        if (bluelight.range >= 10 && greenlight.range >= 10 && stonelight.range >= 10){
        	Debug.Log("Victory room open");
        	Destroy(gameObject);
        }
    }
}
