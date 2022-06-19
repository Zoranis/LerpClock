using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct AngleCouple
{
    public float angle1;
    public float angle2;
}

public class Clock : MonoBehaviour
{

    [SerializeField] Transform hand1;
    [SerializeField] Transform hand2;

    [SerializeField] float speed = 0.01f;

    [SerializeField] private float angle1;
    [SerializeField] private float angle2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DateTime time = System.DateTime.Now;

        //angle1 = -time.Minute * 360 / 60;
        //angle2 = -time.Second * 360 / 60;

        hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), speed);
        hand2.rotation = Quaternion.Lerp(hand2.rotation, Quaternion.Euler(0, 0, angle2), speed);

        if (angle1 == 1)
        {
            show(false);
        }
        else
        {
            show(true);
        }

    }

    private void show(bool visible)
    {
        hand1.gameObject.SetActive(visible);
        hand2.gameObject.SetActive(visible);
    }


    public void shape(int corner)
    {
        switch (corner)
        {
            case 0:
                angle1 = 1;
                break;
            case 1:
                angle1 = 0;
                angle2 = -90;
                break;
            case 2:
                angle1 = -90;
                angle2 = 90;
                break;
            case 3:
                angle1 = 90;
                angle2 = 0;
                break;
            case 4:
                angle1 = 0;
                angle2 = 180;
                break;
            case 7:
                angle1 = -90;
                angle2 = 180;
                break;
            case 9:
                angle1 = 90;
                angle2 = 180;
                break;
            default:
                angle1 = 0;
                break;

        }
    }
}
