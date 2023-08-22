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
    void Update()
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
    }
}
