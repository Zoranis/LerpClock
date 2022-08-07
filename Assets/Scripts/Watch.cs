using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{

    [SerializeField] private Digit[] digits = new Digit[6];
    private DateTime _time;

    // Update is called once per frame
    void Update()
    {
        _time = System.DateTime.Now;

        int hourTens = Tens(_time.Hour);
        int hourOnes = Ones(_time.Hour);

        int minuteTens = Tens(_time.Minute);
        int minuteOnes = Ones(_time.Minute);

        int secondTens = Tens(_time.Second);
        int secondOnes = Ones(_time.Second);

        
        digits[0].ShowDigit(hourTens);
        digits[1].ShowDigit(hourOnes);
        digits[2].ShowDigit(minuteTens);
        digits[3].ShowDigit(minuteOnes);
        digits[4].ShowDigit(secondTens);
        digits[5].ShowDigit(secondOnes);
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
