using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    
    private Vector2 movement;
    private Vector2 screenBounds;
    private float playerHalfWidth;
    private float xPosLastFrame;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        playerHalfWidth = spriteRenderer.bounds.extents.x;
    }
    void Update()
    {
        HandleMovement();
        FlipCharacterX();
    }

    private void FlipCharacterX()
    {
        if (transform.position.x > xPosLastFrame){
            // We are moving right
            spriteRenderer.flipX = false;
        }
        else if (transform.position.x < xPosLastFrame){
            // We are moving left
            spriteRenderer.flipX = true;
        }

        xPosLastFrame = transform.position.x;
    }

    private void HandleMovement()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
        if (input != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
