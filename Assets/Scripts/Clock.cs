using UnityEngine;


public struct AngleCouple
{
    public float Angle1;
    public float Angle2;
}

public class Clock : MonoBehaviour
{

    [SerializeField] private Transform hand1;
    [SerializeField] private Transform hand2;

    //[SerializeField] float speed = 0.01f;

    private float _angle1;
    private float _angle2;

    private float _length1;
    private float _length2;


    private Quaternion _previousRotation1;
    private Quaternion _previousRotation2;

    private float _previousLength1;
    private float _previousLength2;


    void Update()
    {

        hand1.rotation = Quaternion.Lerp(hand1.rotation, Quaternion.Euler(0, 0, _angle1), Manager.Instance.speed);
        hand2.rotation = Quaternion.Lerp(hand2.rotation, Quaternion.Euler(0, 0, _angle2), Manager.Instance.speed);

        var localScale = hand1.localScale;
        var scale = hand2.localScale;
        
        localScale = new Vector3(localScale.x, Mathf.Lerp(_previousLength1, _length1, Manager.Instance.speed), localScale.z);
        hand1.localScale = localScale;
        scale = new Vector3(scale.x, Mathf.Lerp(_previousLength2, _length2, Manager.Instance.speed), scale.z);
        hand2.localScale = scale;
    }

    public void Shape(int corner)
    {

        _previousRotation1 = hand1.rotation;
        _previousRotation2 = hand2.rotation;

        _previousLength1 = hand1.localScale.y;
        _previousLength2 = hand2.localScale.y;

        switch (corner)
        {
            case 0: // invisible
                _length1 = 0;
                _length2 = 0;
                break;
            case 1: // Bottom left corner
                _angle1 = 0;
                _angle2 = -90;
                _length1 = 1;
                _length2 = 1;
                break;
            case 2: // Horizontal line
                _angle1 = -90;
                _angle2 = 90;
                _length1 = 1;
                _length2 = 1;
                break;
            case 3: // Bottom right corner
                _angle1 = 90;
                _angle2 = 0;
                _length1 = 1;
                _length2 = 1;
                break;
            case 4: // Vertical line
                _angle1 = 0;
                _angle2 = 180;
                _length1 = 1;
                _length2 = 1;
                break;
            case 6: // Vertical line
                _angle1 = 0;
                _angle2 = 180;
                _length1 = 1;
                _length2 = 1;
                break;
            case 7: // Top left corner
                _angle1 = -90;
                _angle2 = 180;
                _length1 = 1;
                _length2 = 1;
                break;
            case 8: // Horizontal line
                _angle1 = -90;
                _angle2 = 90;
                _length1 = 1;
                _length2 = 1;
                break;
            case 9: // Top right corner
                _angle1 = 90;
                _angle2 = 180;
                _length1 = 1;
                _length2 = 1;
                break;
            case 81: // Top short line
                _angle1 = 0;
                _angle2 = 0;
                _length1 = 1;
                _length2 = 1;
                break;
            case 41: // Left short line
                _angle1 = 270;
                _angle2 = 270;
                _length1 = 1;
                _length2 = 1;
                break;
            case 61: // Right short line
                _angle1 = -90;
                _angle2 = -90;
                _length1 = 1;
                _length2 = 1;
                break;
            case 21: // Bottom short line
                _angle1 = 180;
                _angle2 = 180;
                _length1 = 1;
                _length2 = 1;
                break;


            default:
                _angle1 = 0;
                break;

        }
    }
}
