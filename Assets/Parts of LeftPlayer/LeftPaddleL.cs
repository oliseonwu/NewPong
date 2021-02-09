using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleL : MonoBehaviour
{
    public BallScript ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        ball.transform.Rotate(Vector3.forward);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "RightPlayer")
        {

            ball.transform.Rotate(Vector3.forward, 225);
        }
        if (other.gameObject.tag == "TopWall")
        {

            ball.transform.Rotate(Vector3.forward, 180);
        }
        if (other.gameObject.tag == "bottomwall")
        {

            ball.transform.Rotate(Vector3.forward, 270);
        }
        other.gameObject.tag= gameObject.tag;
        
    }
}
