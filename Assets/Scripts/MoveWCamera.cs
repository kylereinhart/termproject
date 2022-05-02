using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWCamera : MonoBehaviour
{
    public CharacterController player;

    public float speed = 12f;

    private bool groundedPlayer;

    // Update is called once per frame
    void Update()
    {
        
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        groundedPlayer = player.isGrounded;
        if (groundedPlayer && move.y < 0)
        {
            move.y = 0f;
        }
        
        move.y += -9.81f * Time.deltaTime; 

        player.Move(move * speed * Time.deltaTime);
    }
}
