using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_script : MonoBehaviour
{
    public float pushPower = 4.0F;
    CharacterController cc;


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
            return;

        if (hit.moveDirection.y < -0.3f)
            return;

     
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        body.velocity = pushDir * pushPower;

        //Allows player to push blocks they are touching
        //Player will push any object with a rigidbody and is not a kinematic

    
    }


    // Start is called before the first frame update
    void Start()
    {
        //cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
            Application.Quit();
            #endif
        }
    }
}
