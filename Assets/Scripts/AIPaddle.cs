using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
    [SerializeField] GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.Ball.transform.position.y>0)
        {
            if(this.Ball.transform.position.x > transform.position.x)
            {
                RigidBody.AddForce(Vector2.right * this.Speed);
            }
            else if(this.Ball.transform.position.x < transform.position.x)
            {
                RigidBody.AddForce(Vector2.left * this.Speed);
            }
        }
        else
        {
            if (this.Ball.transform.position.x > 0)
            {
                RigidBody.AddForce(Vector2.left * this.Speed);
            }
            else if (this.Ball.transform.position.x < 0)
            {
                RigidBody.AddForce(Vector2.right * this.Speed);
            }
        }
    }
}
