using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    [SerializeField] Transform hand1;
    [SerializeField] Transform hand2;

    [SerializeField] float speed = 0.01f;
    [SerializeField] float timeCount = 0.0f;

    private float angle1;
    private float angle2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = System.DateTime.Now;

        angle1 = time.Hour * 360 / 12;
        angle2 = time.Minute * 360 / 60;

        hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), timeCount * speed);
        hand2.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle2), timeCount * speed);



    }
}
