using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1Area5ElevatorMover : MonoBehaviour
{
    public Vector3[] locations = {
    new Vector3 { x = -70, y = 0.05f, z = 0.2f },
    new Vector3 { x = -70, y = 0.05f, z = 0.2f },
    new Vector3 { x = -70, y = 55, z = 0.2f },
    new Vector3 { x = -70, y = 55, z = 0.2f }
    };

    private int nextPointIndex = 0;
    public float speed1 = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var reachedNextPoint = transform.position == locations[nextPointIndex];

        if (reachedNextPoint)
        {
            nextPointIndex++;
            if (nextPointIndex >= locations.Length)
            {
                nextPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, locations[nextPointIndex], speed1 * Time.deltaTime);
    }
}
