using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDigit", menuName = "Shapes/Digits")]
public class Digit : ScriptableObject
{

    public int digit;
    public AngleCouple[,] Angles = new AngleCouple[5, 3];

}
