using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct AngleCouple
{
    public float angle1;
    public float angle2;
}

public class Clock : MonoBehaviour
{

    [SerializeField] Transform hand1;
    [SerializeField] Transform hand2;

    //[SerializeField] float speed = 0.01f;

    private float angle1;
    private float angle2;

    private float length1;
    private float length2;


    private Quaternion previousRotation1;
    private Quaternion previousRotation2;

    private float previousLength1;
    private float previousLength2;


    void Update()
    {

        hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, angle1), Manager.instance.speed);
        hand2.rotation = Quaternion.Lerp(hand2.rotation, Quaternion.Euler(0, 0, angle2), Manager.instance.speed);

        hand1.localScale = new Vector3(hand1.localScale.x, Mathf.Lerp(previousLength1, length1, Manager.instance.speed), hand1.localScale.z);
        hand2.localScale = new Vector3(hand2.localScale.x, Mathf.Lerp(previousLength2, length2, Manager.instance.speed), hand2.localScale.z);

    }

    public void shape(int corner)
    {

        previousRotation1 = hand1.rotation;
        previousRotation2 = hand2.rotation;

        previousLength1 = hand1.localScale.y;
        previousLength2 = hand2.localScale.y;

        switch (corner)
        {
            case 0: // invisible
                length1 = 0;
                length2 = 0;
                break;
            case 1: // Bottom left corner
                angle1 = 0;
                angle2 = -90;
                length1 = 1;
                length2 = 1;
                break;
            case 2: // Horizontal line
                angle1 = -90;
                angle2 = 90;
                length1 = 1;
                length2 = 1;
                break;
            case 3: // Bottom right corner
                angle1 = 90;
                angle2 = 0;
                length1 = 1;
                length2 = 1;
                break;
            case 4: // Vertical line
                angle1 = 0;
                angle2 = 180;
                length1 = 1;
                length2 = 1;
                break;
            case 6: // Vertical line
                angle1 = 0;
                angle2 = 180;
                length1 = 1;
                length2 = 1;
                break;
            case 7: // Top left corner
                angle1 = -90;
                angle2 = 180;
                length1 = 1;
                length2 = 1;
                break;
            case 8: // Horizontal line
                angle1 = -90;
                angle2 = 90;
                length1 = 1;
                length2 = 1;
                break;
            case 9: // Top right corner
                angle1 = 90;
                angle2 = 180;
                length1 = 1;
                length2 = 1;
                break;
            case 81: // Top short line
                angle1 = 0;
                angle2 = 0;
                length1 = 1;
                length2 = 1;
                break;
            case 41: // Left short line
                angle1 = 270;
                angle2 = 270;
                length1 = 1;
                length2 = 1;
                break;
            case 61: // Right short line
                angle1 = -90;
                angle2 = -90;
                length1 = 1;
                length2 = 1;
                break;
            case 21: // Bottom short line
                angle1 = 180;
                angle2 = 180;
                length1 = 1;
                length2 = 1;
                break;


            default:
                angle1 = 0;
                break;

        }
    }
}
