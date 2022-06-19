using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digit : MonoBehaviour
{

    // Holds the clock elements
    [SerializeField] Clock[] clocks = new Clock[15];
    [SerializeField] int initialDigit = 0;

    #region digit arrays

    int[][] digitShapes = new int[10][]{

    new int[] { 7,8,9,4,0,6,1,2,3 }, // 0
    new int[] { }, // 1
    new int[] { }, // 2
    new int[] { }, // 3
    new int[] { }, // 4
    new int[] { }, // 5
    new int[] { }, // 6
    new int[] { }, // 7
    new int[] { }, // 8
    new int[] { }  // 9

};







    #endregion


    // Start is called before the first frame update
    void Start()
    {
        showDigit(initialDigit);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void showDigit(int num)
    {
        for (int i = 0; i < 15; i++)
        {
            clocks[i].shape(digitShapes[num][i]);
        }
    }
}
