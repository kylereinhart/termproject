using System;
using System.Collections;
using System.Collections.Generic;
using Scripts.Motor;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private IMotor m_motor;

    private void Awake() {
        AddDependencies();
    }

    void AddDependencies() {
        m_motor = gameObject.AddComponent<PlayerMotor>();
    }

    private void Update() {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W)) {
            movement += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S)) {
            movement+= Vector3.forward * -1; 
        }

        if (Input.GetKey(KeyCode.A)) {
            movement += Vector3.right * - 1;
        }
            
        if (Input.GetKey(KeyCode.D)) {
            movement += Vector3.right;
        }

        m_motor.Move(movement);
        
    }
}
