using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float sprintSpeed = 10.0f;
    public float baseSpeed = 5.0f;
    //public float stamina = 100;
    
    public CharacterController player;
    public LayerMask groundMask;

    private bool isGrounded;
    Vector3 velocity;

    [SerializeField] private GameObject uiManager;
    private UIManager uiManagerScript;

    [SerializeField] private Slider staminaBar;
    [SerializeField] private float maxStamina;
    private bool sprinting = false;

    void Start()
    {
        uiManagerScript = uiManager.GetComponent<UIManager>();
        staminaBar.value = maxStamina;
    }
    
    void FixedUpdate()
    {
        // Keyboard Input
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");
        Vector3 move = transform.right * xMove + transform.forward * zMove;
        player.Move(move * speed * Time.deltaTime);
        //staminaBar.value = Math.Clamp(staminaBar.value, 0, 100); 
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {   
            speed = sprintSpeed;
            staminaBar.value -= 0.005f;
            if(staminaBar.value <= 0){
                speed = baseSpeed;
            }
        } else {
            speed = baseSpeed;
            staminaBar.value += 0.002f;
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

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemy") {
            Debug.Log("Game Over");
            uiManagerScript.GameOver();
        }
    }
}
