using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxRotation : MonoBehaviour
{
    public float minAngle;
    public float maxAngle;
    private float rotationx;

    void FixedUpdate()
    {
        rotationx = Mathf.Clamp(rotationx, minAngle, maxAngle);
        transform.localEulerAngles = new Vector3(-rotationx, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
