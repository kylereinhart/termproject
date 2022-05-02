using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    public float mouseSensitivity = 100f;
    
    public Transform playerbody;

    float xRotate = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (Input.GetKey(KeyCode.W)) {
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
        }*/

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        
        playerbody.Rotate(Vector3.up * mouseX);
    }
}