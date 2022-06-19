using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digit : MonoBehaviour
{

    // Holds the clock elements
    [SerializeField] Clock[] clocks = new Clock[15];

    #region digit arrays

    AngleCouple[][] digits = new AngleCouple[10][];

    digits[0] = new AngleCouple[15];

    


    
    



    #endregion


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
