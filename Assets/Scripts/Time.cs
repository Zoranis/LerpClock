using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{

    [SerializeField] Digit[] digits = new Digit[6];
    private DateTime time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = System.DateTime.Now;

        int hourTens = Tens(time.Hour);
        int hourOnes = Ones(time.Hour);

        int minuteTens = Tens(time.Minute);
        int minuteOnes = Ones(time.Minute);

        int secondTens = Tens(time.Second);
        int secondOnes = Ones(time.Second);

        
        digits[0].showDigit(hourTens);
        digits[1].showDigit(hourOnes);
        digits[2].showDigit(minuteTens);
        digits[3].showDigit(minuteOnes);
        digits[4].showDigit(secondTens);
        digits[5].showDigit(secondOnes);
    }


    private int Tens(int value)
    {
        return (value / 10);
    }

    private int Ones(int value)
    {
        return (value % 10);
    }
}
