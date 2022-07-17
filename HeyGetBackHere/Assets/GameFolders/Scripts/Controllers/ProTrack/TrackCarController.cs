using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCarController : MonoBehaviour
{
    public WheelCollider[] wheels = new WheelCollider[4];
    float _torque = 200;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i].motorTorque = _torque;
            }            
        }
        else
        {
            for (int i = 0; i < wheels.Length; i++)
            {
                wheels[i].motorTorque = 0;
            }
        }
    }
}
