using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ball;
    private float moveVelocity = 200f;
    // Start is called before the first frame update
    void Start()
    {
        this.ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.ball.AddForce(transform.up * moveVelocity, ForceMode.Force);
            this.ball.AddForce(transform.right * moveVelocity, ForceMode.Force);
        }

        //if(input.GetMouseButtonDown(0))
        //{
            
        //}
    }
}
