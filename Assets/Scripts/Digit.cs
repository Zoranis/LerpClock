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

    new int[] { 7,8,9,  // 0
                4,0,6,
                4,0,6,
                4,0,6,
                1,2,3 },

    new int[] { 0,9,0,  // 1
                0,4,0,
                0,4,0,
                0,4,0,
                0,3,0, },

    new int[] { 7,8,9,  // 2
                0,0,6,
                7,8,3,
                4,0,0,
                1,2,3 },

    new int[] { 7,8,9,  // 3
                0,0,6,
                0,8,6,
                0,0,6,
                1,2,3 },

    new int[] { 7,0,9,  // 4
                4,0,4,
                1,8,4,
                0,0,4,
                0,0,4 },

    new int[] { 7,8,9,  // 5
                4,0,0,
                1,2,9,
                0,0,6,
                1,2,3 },

    new int[] { 7,8,9,  // 6
                4,0,0,
                4,8,9,
                4,0,6,
                1,2,3 },

    new int[] { 7,8,9,  // 7
                0,0,6,
                0,0,6,
                0,0,6,
                0,0,6 },

    new int[] { 7,8,9,  // 8
                4,0,6,
                4,8,6,
                4,0,6,
                1,2,3 },

    new int[] { 7,8,9,  // 9
                4,0,6,
                1,2,6,
                0,0,6,
                1,2,3 }


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
