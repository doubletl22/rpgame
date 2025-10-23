using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Lấy input trái/phải (-1 đến 1)
        moveInput = Input.GetAxisRaw("Horizontal");

        // Di chuyển nhân vật
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Xoay hướng nhân vật
        if (moveInput != 0)
        {
            transform.localScale = new Vector3(moveInput > 0 ? 1 : -1, 1, 1);
        }

        // Kiểm tra có đang chạy hay không
        bool isRunning = Mathf.Abs(moveInput) > 0.01f;
        animator.SetBool("isRunning", isRunning);
    }
}
