using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sprintSpeed = 10.0f;
    public float baseSpeed = 5.0f;
    public CharacterController player;
    public LayerMask groundMask;

    private bool isGrounded;
    public Vector3 velocity;
    

    void FixedUpdate()
    {
        // Keyboard Input
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");
        Vector3 move = transform.right * xMove + transform.forward * zMove;
        player.Move(move * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            speed = sprintSpeed;
        } else {
            speed = baseSpeed;
        }
        isGrounded = Physics.Raycast(player.transform.position, Vector3.down, (player.height / 2) + 0.1f, groundMask);
        if (isGrounded && velocity.y < 0) {
            velocity.y = 0f;
        }
        if (!isGrounded) {
            velocity.y += -9.8f;
            player.Move(velocity * Time.deltaTime);
        }
    }
}
