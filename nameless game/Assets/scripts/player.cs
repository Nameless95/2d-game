using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rigidbodoy2d;
    public float speed = 3.0f;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rigidbodoy2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        if (transform.position.magnitude > 10) {

            animator.SetTrigger("corruption");
        }

    }

     void FixedUpdate()
    {
        Vector2 position = rigidbodoy2d.position;
        position.x = position.x + speed * horizontal *Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbodoy2d.MovePosition(position);
    }

}
