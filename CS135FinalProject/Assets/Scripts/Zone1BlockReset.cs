using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1BlockReset : MonoBehaviour
{
    //List of every pushable block (theres a lot)
    
    //Area1
    public Transform obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10;
    public Transform obj11, obj12, obj13, obj14, obj15, obj16, obj17, obj18, obj19, obj20;
    public Transform obj21, obj22, obj23, obj24, obj25, obj26, obj27, obj28, obj29, obj30;
    public Transform obj31, obj32, obj33, obj34, obj35, obj36, obj37, obj38, obj39, obj40;
    public Transform obj41, obj42, obj43, obj44, obj45, obj46, obj47;

    private Vector3 origPos1, origPos2, origPos3, origPos4, origPos5, origPos6, origPos7, origPos8, origPos9, origPos10;
    private Vector3 origPos11, origPos12, origPos13, origPos14, origPos15, origPos16, origPos17, origPos18, origPos19, origPos20;
    private Vector3 origPos21, origPos22, origPos23, origPos24, origPos25, origPos26, origPos27, origPos28, origPos29, origPos30;
    private Vector3 origPos31, origPos32, origPos33, origPos34, origPos35, origPos36, origPos37, origPos38, origPos39, origPos40;
    private Vector3 origPos41, origPos42, origPos43, origPos44, origPos45, origPos46, origPos47;

    //Area2
    public Transform a2obj1;

    private Vector3 a2origPos1;

    //Area3
    public Transform a3obj1, a3obj2, a3obj3;

    private Vector3 a3origPos1, a3origPos2, a3origPos3;

    //Area4
    public Transform a4obj1;

    private Vector3 a4origPos1;
    private Quaternion a4origOren1;

    // Start is called before the first frame update
    void Start()
    {
        //Area1
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
        origPos13 = obj13.transform.position;
        origPos14 = obj14.transform.position;
        origPos15 = obj15.transform.position;
        origPos16 = obj16.transform.position;
        origPos17 = obj17.transform.position;
        origPos18 = obj18.transform.position;
        origPos19 = obj19.transform.position;
        origPos20 = obj20.transform.position;
        origPos21 = obj21.transform.position;
        origPos22 = obj22.transform.position;
        origPos23 = obj23.transform.position;
        origPos24 = obj24.transform.position;
        origPos25 = obj25.transform.position;
        origPos26 = obj26.transform.position;
        origPos27 = obj27.transform.position;
        origPos28 = obj28.transform.position;
        origPos29 = obj29.transform.position;
        origPos30 = obj30.transform.position;
        origPos31 = obj31.transform.position;
        origPos32 = obj32.transform.position;
        origPos33 = obj33.transform.position;
        origPos34 = obj34.transform.position;
        origPos35 = obj35.transform.position;
        origPos36 = obj36.transform.position;
        origPos37 = obj37.transform.position;
        origPos38 = obj38.transform.position;
        origPos39 = obj39.transform.position;
        origPos40 = obj40.transform.position;
        origPos41 = obj41.transform.position;
        origPos42 = obj42.transform.position;
        origPos43 = obj43.transform.position;
        origPos44 = obj44.transform.position;
        origPos45 = obj45.transform.position;
        origPos46 = obj46.transform.position;
        origPos47 = obj47.transform.position;

        //Area2
        a2origPos1 = a2obj1.transform.position;

        //Area3
        a3origPos1 = a3obj1.transform.position;
        a3origPos2 = a3obj2.transform.position;
        a3origPos3 = a3obj3.transform.position;

        //Area4
        a4origPos1 = a4obj1.transform.position;
        a4origOren1 = a4obj1.transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //reset block button
        {
            //Area1
            obj1.transform.position = origPos1;
            obj2.transform.position = origPos2;
            obj3.transform.position = origPos3;
            obj4.transform.position = origPos4;
            obj5.transform.position = origPos5;
            obj6.transform.position = origPos6;
            obj7.transform.position = origPos7;
            obj8.transform.position = origPos8;
            obj9.transform.position = origPos9;
            obj10.transform.position = origPos10;
            obj11.transform.position = origPos11;
            obj12.transform.position = origPos12;
            obj13.transform.position = origPos13;
            obj14.transform.position = origPos14;
            obj15.transform.position = origPos15;
            obj16.transform.position = origPos16;
            obj17.transform.position = origPos17;
            obj18.transform.position = origPos18;
            obj19.transform.position = origPos19;
            obj20.transform.position = origPos20;
            obj21.transform.position = origPos21;
            obj22.transform.position = origPos22;
            obj23.transform.position = origPos23;
            obj24.transform.position = origPos24;
            obj25.transform.position = origPos25;
            obj26.transform.position = origPos26;
            obj27.transform.position = origPos27;
            obj28.transform.position = origPos28;
            obj29.transform.position = origPos29;
            obj30.transform.position = origPos30;
            obj31.transform.position = origPos31;
            obj32.transform.position = origPos32;
            obj33.transform.position = origPos33;
            obj34.transform.position = origPos34;
            obj35.transform.position = origPos35;
            obj36.transform.position = origPos36;
            obj37.transform.position = origPos37;
            obj38.transform.position = origPos38;
            obj39.transform.position = origPos39;
            obj40.transform.position = origPos40;
            obj41.transform.position = origPos41;
            obj42.transform.position = origPos42;
            obj43.transform.position = origPos43;
            obj44.transform.position = origPos44;
            obj45.transform.position = origPos45;
            obj46.transform.position = origPos46;
            obj47.transform.position = origPos47;

            //Area2
            a2obj1.transform.position = a2origPos1;

            //Area3
            a3obj1.transform.position = a3origPos1;
            a3obj2.transform.position = a3origPos2;
            a3obj3.transform.position = a3origPos3;

            //Area4
            a4obj1.transform.position = a4origPos1;
            a4obj1.transform.rotation = a4origOren1;
        }
    }
}
