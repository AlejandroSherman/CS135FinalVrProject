using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1Area4SpotlightMover : MonoBehaviour
{
    public Vector3[] points = {
    new Vector3 { x = -55, y = 70, z = 72 }, 
    new Vector3 { x = -55, y = 70, z = 45 }, 
    new Vector3 { x = -38, y = 90, z = 45 },
    new Vector3 { x = -18, y = 70, z = 45 },
    new Vector3 { x = -5, y = 90, z = 45 },
    new Vector3 { x = 12, y = 70, z = 45 },
    new Vector3 { x = 24, y = 90, z = 45 },
    new Vector3 { x = 45, y = 70, z = 45 },
    new Vector3 { x = 65, y = 90, z = 45 },
    new Vector3 { x = 65, y = 70, z = 72 },
    new Vector3 { x = 45, y = 70, z = 72 },
    new Vector3 { x = 24, y = 90, z = 72 },
    new Vector3 { x = 12, y = 70, z = 72 },
    new Vector3 { x = -5, y = 90, z = 72 },
    new Vector3 { x = -18, y = 70, z = 72 },
    new Vector3 { x = -38, y = 90, z = 72}  } ;
    
    //new Vector3 { x = -38, y = 85, z = 72 },
    //new Vector3 { x = -18, y = 70, z = 72 },
    //new Vector3 { x = -5, y = 85, z = 72 },
    //new Vector3 { x = 12, y = 70, z = 72 },
    //new Vector3 { x = 24, y = 85, z = 72 },
    //new Vector3 { x = 45, y = 70, z = 72 },
    //new Vector3 { x = 65, y = 70, z = 72 },
    //new Vector3 { x = 65, y = 70, z = 45 },
    //new Vector3 { x = 45, y = 70, z = 45 },
    //new Vector3 { x = 24, y = 85, z = 45 },
    //new Vector3 { x = 12, y = 70, z = 45 },
    //new Vector3 { x = -5, y = 85, z = 45 },
    //new Vector3 { x = -18, y = 70, z = 45 },
    //new Vector3 { x = -38, y = 85, z = 45 },
    //new Vector3 { x = -55, y = 70, z = 45 },
    //new Vector3 { x = -55, y = 70, z = 72 } };



    private int nextPointIndex = 0;
    public float speed = 28;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var reachedNextPoint = transform.position == points[nextPointIndex];

        if (reachedNextPoint)
        {
            nextPointIndex++;
            if (nextPointIndex >= points.Length)
            {
                nextPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);

    }
}
