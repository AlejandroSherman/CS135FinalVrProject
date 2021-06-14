using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1Area2LightSwitcher : MonoBehaviour
{
    public List<Light> ZoneLights;
    public static float nextActionTime = 0.0f;
    public float period = 12f;
    public static int curr_int = 0;
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            // execute block of code here
            //if (count % 2 == 0)
            //{
            if (curr_int == 0)
            {
                ZoneLights[0].color = Color.white;
                curr_int = 1;
                ZoneLights[1].color = Color.red;
            }
            else if (curr_int == 1)
            {
                ZoneLights[1].color = Color.white;
                curr_int = 2;
                ZoneLights[2].color = Color.red;
            }
            else if (curr_int == 2)
            {
                ZoneLights[2].color = Color.white;
                curr_int = 3;
                ZoneLights[3].color = Color.red;
            }
            else if (curr_int == 3)
            {
                ZoneLights[3].color = Color.white;
                curr_int = 0;
                ZoneLights[0].color = Color.red;
            }
            //else if (curr_int == 1)
            //{
            //    curr_int = 2;
            //}
            //else if (curr_int == 2)
            //{
            //   curr_int = 0;
            //}
            //}
            //ZoneLights[curr_int].enabled = !ZoneLights[curr_int].enabled;
            //count++;
        }
    }
}