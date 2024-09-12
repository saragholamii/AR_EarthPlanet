using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject planetObject;
    public Vector3 rotationVector;


    private void Update()
    {
        planetObject.transform.Rotate(rotationVector * Time.deltaTime);
    }
}
