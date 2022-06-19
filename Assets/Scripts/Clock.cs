using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        angle1 = -time.Minute * 360 / 60;
        angle2 = -time.Second * 360 / 60;

        hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), speed);
        hand2.rotation = Quaternion.Lerp(hand2.rotation, Quaternion.Euler(0, 0, angle2), speed);

        //hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), timeCount * speed);
        //hand2.rotation = Quaternion.Lerp(hand2.rotation, Quaternion.Euler(0, 0, angle2), timeCount * speed);

        //angle1 = -time.Hour * 360 / 12;
        //angle2 = -time.Minute * 360 / 60;

        //hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), timeCount * speed);
        //hand2.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle2), timeCount * speed);

        //angle1 = -time.Second * 360 / 60;
        //hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), timeCount * speed);

        //Debug.Log("Seconds: " + time.Second.ToString());
        //Debug.Log("Angle: " + angle1);

    }
}
