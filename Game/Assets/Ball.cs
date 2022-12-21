using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody ball;
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
            this.ball.AddForce(transform.right * 1000);
            this.ball.AddForce(transform.up * 1000);
        }
    }
}
