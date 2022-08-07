using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] public float speed = 0.01f;

    public static Manager Instance;

    private void Awake()
    {
        Instance = this;
    }


}
