using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float velocity;
    public int id;
    Rigidbody2D rgb;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        switch (id)
        {
            case 1:
                if (Input.GetKey(KeyCode.W))
                {
                    rgb.velocity = Vector2.up * velocity;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    rgb.velocity = Vector2.down * velocity;
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    rgb.velocity = Vector2.left * velocity;
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    rgb.velocity = Vector2.right * velocity;
                }
                break;
            case 2:
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rgb.velocity = Vector2.up * velocity;
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    rgb.velocity = Vector2.down * velocity;
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rgb.velocity = Vector2.left * velocity;
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    rgb.velocity = Vector2.right * velocity;
                }
                break;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            rgb.velocity = Vector2.zero;
        }
    }
}
