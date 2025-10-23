using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diChuyen : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public int speed = 4;
    public float walk;
    public bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walk = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(walk * speed, rb.velocity.y);

        if (isFacingRight == true && walk == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            isFacingRight = false;
        }
        else if (isFacingRight == false && walk == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            isFacingRight = true;
        }

        anim.SetFloat("isRunning", Mathf.Abs(walk));

    }
}
