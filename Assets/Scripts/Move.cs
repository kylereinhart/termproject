using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 movement;

    public Move()
    {
        movement = transform.position;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}
