using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private int speed;
    //float minX, maxX, minY, maxY;
    private ball myBall;

    private void Update()
    {
        Movement();
        Lanzar();
    }
    public void Lanzar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myBall.Lanzar();
        }
    }
    public void SetBall(ball ball)
    {
        myBall = ball;
    }

    void Movement()
    {
        float movH = Input.GetAxis("Horizontal");
        float movV = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(movH * Time.deltaTime * speed, movV * Time.deltaTime * speed));
        if (movH != 0)
        {
            transform.localScale = new Vector2((Mathf.Sign(movH)) * 2, 2);
        }
    }

}
