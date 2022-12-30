using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ball;
    private float moveVelocity = 200f;
    private Ray ray;
    private RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ball.AddForce(transform.up * moveVelocity, ForceMode.Force);
            ball.AddForce(transform.right * moveVelocity, ForceMode.Force);

        }

        if(Input.GetMouseButtonDown(0))
        {
            if(ClickEvent("Ball"))
            {
                Debug.Log("Å¬¸¯µÊ");
            }
        }
    }

    bool ClickEvent(string tagName)
    {
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.transform.gameObject);

            if (hit.transform.gameObject.tag == tagName)
            {
                return true;
            }
        }
        return false;
    }

    //private void FixedUpdate()
    //{
    //}
}
