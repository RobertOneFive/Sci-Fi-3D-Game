using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookYAxis : MonoBehaviour
{
    private float _sensitivity = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

       Vector3 newRotation = transform.localEulerAngles;
       newRotation.x += _mouseY * _sensitivity;

       transform.localEulerAngles = newRotation;
        
    }
}
