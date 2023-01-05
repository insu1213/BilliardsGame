using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int firstTouch;
    int wallTouch;

    // Start is called before the first frame update
    void Start()
    {
        firstTouch = 0;
        wallTouch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Yellow Ball" && firstTouch == 0)
        {
            firstTouch = 1;
            return;
        }

        if(collision.collider.tag == "White Ball" && firstTouch == 0)
        {
            firstTouch = 2;
            return;
        }
        if(wallTouch >= 3) // 3ƒÌº«¿œ ∞ÊøÏ (µÊ¡°ªÛ»≤)
        {
            if (collision.collider.tag == "Yellow Ball" && firstTouch == 2)
            {
                Debug.Log("µÊ¡°¿‘¥œ¥Ÿ.");
                firstTouch = 0;
                wallTouch = 0;
            } else if(collision.collider.tag == "Yellow Ball")
            {
                firstTouch = 0;
                wallTouch = 0;
            }

            if (collision.collider.tag == "White Ball" && firstTouch == 1)
            {
                Debug.Log("µÊ¡°¿‘¥œ¥Ÿ.");
                firstTouch = 0;
                wallTouch = 0;
            } else if (collision.collider.tag == "White Ball")
            {
                firstTouch = 0;
                wallTouch = 0;
            }
        }
        
        if(collision.collider.tag == "Wall")
        {
            wallTouch++;
        }
    }
}
