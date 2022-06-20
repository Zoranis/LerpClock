using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    [SerializeField] public float speed = 0.01f;

    static public Manager instance;

    private void Awake()
    {
        instance = this;
    }


}
