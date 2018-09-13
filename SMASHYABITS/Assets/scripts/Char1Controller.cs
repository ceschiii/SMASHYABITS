using System.Collections;
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
        rigid = GetComponent < Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow))
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(moveHorizontal, 0);
            rigid.AddForce(movement * speed);
        }


        }

    private void Update()
    {
        jumpTimer -= Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float moveVertical = Input.GetAxis("Vertical");
            if (jumpTimer < 0 && moveVertical > 0)
                {
                    rigid.velocity = new Vector2(0, 10);
                    //            rigid.AddForce(new Vector2(0, moveVertical * jumpPower));
                    jumpTimer = 2;
                }
        }
            
    }

}