using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;
    public CharacterController player;
    void Update()
    {
        // Keyboard Input
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");
        Vector3 move = transform.right * xMove + transform.forward * zMove;
        player.Move(move * speed * Time.deltaTime);
    }
}
