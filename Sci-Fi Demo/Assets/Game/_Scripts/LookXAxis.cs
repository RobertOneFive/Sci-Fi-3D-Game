using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookXAxis : MonoBehaviour
{
    private float _sensitivity = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float _mouseX = Input.GetAxis("Mouse X");

       Vector3 newRotation = transform.localEulerAngles;
       newRotation.y += _mouseX * _sensitivity;

       transform.localEulerAngles = newRotation;
              //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + (_mouseX * _sensitivity), transform.localEulerAngles.z); 

    }
}
