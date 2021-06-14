using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1CaughtUnder : MonoBehaviour
{
    //This file will catch the player if they come into contact with red light, and will update the checkpoint when they contact green light
    
    public Vector3 checkPoint; 
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        checkPoint = (new Vector3(0, -9, -99)); //Normal begin area
        //checkPoint = (new Vector3(-45, -9, -45)); //while developing Area2 
        //checkPoint = (new Vector3(5, -9, 15)); //while developing Area3
        //checkPoint = (new Vector3(32, 0.5f, 91.5f)); //while developing Area4
        //checkPoint = (new Vector3(61, 0.5f, 4)); //while developing Area5
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c")) //reset position button
        {
            cc.enabled = false;
            transform.position = checkPoint; //(new Vector3(0, -9, -95))
            cc.enabled = true;
        }
        else if (Input.GetKeyDown("1"))
        {
            cc.enabled = false;
            checkPoint = (new Vector3(0, -9, -99));
            transform.position = checkPoint; 
            cc.enabled = true;
        }
        else if (Input.GetKeyDown("2"))
        {
            cc.enabled = false;
            checkPoint = (new Vector3(-45, -9, -45));
            transform.position = checkPoint;
            cc.enabled = true;
        }
        else if (Input.GetKeyDown("3"))
        {
            cc.enabled = false;
            checkPoint = (new Vector3(5, -9, 15));
            transform.position = checkPoint;
            cc.enabled = true;
        }
        else if (Input.GetKeyDown("4"))
        {
            cc.enabled = false;
            checkPoint = (new Vector3(32, 0.5f, 91.5f));
            transform.position = checkPoint;
            cc.enabled = true;
        }
        else if (Input.GetKeyDown("5"))
        {
            cc.enabled = false;
            checkPoint = (new Vector3(61, 0.5f, 4));
            transform.position = checkPoint;
            cc.enabled = true;
        }
    }

	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Light>().color == Color.red)
		{
            cc.enabled = false;
            transform.position = checkPoint; //(new Vector3(0, -9, -95))
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.yellow)
        {
            cc.enabled = false;
            transform.position = checkPoint; 
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.green)
        {
            if (other.GetComponent<Light>().intensity == 1)
            {
                checkPoint = (new Vector3(-45, -9, -45));
            }
            else if (other.GetComponent<Light>().intensity == 2)
            {
                checkPoint = (new Vector3(5, -9, 15));
            } 
            else if (other.GetComponent<Light>().intensity == 3)
            {
                checkPoint = (new Vector3(32, 0.5f, 91.5f));
            }
            else if (other.GetComponent<Light>().intensity == 4)
            {
                checkPoint = (new Vector3(61, 0.5f, 4));
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Light>().color == Color.red)
        {
            cc.enabled = false;
            transform.position = checkPoint;
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.yellow)
        {
            cc.enabled = false;
            transform.position = checkPoint;
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.green)
        {
            if (other.GetComponent<Light>().intensity == 1)
            {
                checkPoint = (new Vector3(-45, -9, -45));
            }
            else if (other.GetComponent<Light>().intensity == 2)
            {
                checkPoint = (new Vector3(5, -9, 15));
            }
            else if (other.GetComponent<Light>().intensity == 3)
            {
                checkPoint = (new Vector3(32, 0.5f, 91.5f));
            }
            else if (other.GetComponent<Light>().intensity == 4)
            {
                checkPoint = (new Vector3(61, 0.5f, 4));
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Light>().color == Color.red)
        {
            cc.enabled = false;
            transform.position = checkPoint;
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.yellow) //wanted searchlight to be yellow but it seems yellow has issues, will keep using red then
        {
            cc.enabled = false;
            transform.position = checkPoint;
            cc.enabled = true;
        }
        if (other.GetComponent<Light>().color == Color.green)
        {
            if (other.GetComponent<Light>().intensity == 1)
            {
                checkPoint = (new Vector3(-45, -9, -45));
            }
            else if (other.GetComponent<Light>().intensity == 2)
            {
                checkPoint = (new Vector3(5, -9, 15));
            }
            else if (other.GetComponent<Light>().intensity == 3)
            {
                checkPoint = (new Vector3(32, 0.5f, 91.5f));
            }
            else if (other.GetComponent<Light>().intensity == 4)
            {
                checkPoint = (new Vector3(61, 0.5f, 4));
            }
        }

    }

}
