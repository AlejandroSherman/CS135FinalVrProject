using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_controller_script : MonoBehaviour
{
    CharacterController cc;
    public Transform obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9; 
    private Vector3 origPos1, origPos2, origPos3, origPos4, origPos5, origPos6, origPos7, origPos8, origPos9;

    public Transform obj10, obj11, obj12;
    private Vector3 origPos10, origPos11, origPos12;



    // Start is called before the first frame update
    void Start()
    {
        origPos1 = obj1.transform.position;
        origPos2 = obj2.transform.position;
        origPos3 = obj3.transform.position;
        origPos4 = obj4.transform.position;
        origPos5 = obj5.transform.position;
        origPos6 = obj6.transform.position;
        origPos7 = obj7.transform.position;
        origPos8 = obj8.transform.position;
        origPos9 = obj9.transform.position;
        origPos10 = obj10.transform.position;
        origPos11 = obj11.transform.position;
        origPos12 = obj12.transform.position;

        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")){
            cc.enabled = false;
        	this.transform.position  = new Vector3(-5, 1, -40);
            cc.enabled = true;
        } else if (Input.GetKeyDown("o")){
            obj1.transform.position = origPos1;
            obj2.transform.position = origPos2;
            obj3.transform.position = origPos3;
            obj4.transform.position = origPos4;
            obj5.transform.position = origPos5;
            obj6.transform.position = origPos6;
            obj7.transform.position = origPos7;
            obj8.transform.position = origPos8;
            obj9.transform.position = origPos9;
        } else if (Input.GetKeyDown("c")){
            obj10.transform.position = origPos10;
            obj11.transform.position = origPos11;
            obj12.transform.position = origPos12;
        } else if (Input.GetKeyDown (KeyCode.Escape)){
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        } else {
            return;
        }
    }
}
