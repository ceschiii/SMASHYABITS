﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1Controller : MonoBehaviour
{
    public float jumpTimer = 0;

    public float speed;
    public float jumpPower;
    private Rigidbody2D rigid;


    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = 0;

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1;
        }
    
            Vector2 movement = new Vector2(moveHorizontal, 0);
            rigid.AddForce(movement * speed);
        


    }

    private void Update()
    {
        jumpTimer -= Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            if (jumpTimer < 0)
            {
                rigid.velocity = new Vector2(0, 10);
                jumpTimer = 1;
            }
        }

    }

}