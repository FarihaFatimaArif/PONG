using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    Vector2 direction;
    public GetInput input;
    // Start is called before the first frame update
    private void Awake()
    {
        RigidBody = GetComponent<Rigidbody2D>();
        input = GetComponent<GetInput>();
        direction = this.transform.position;
    }
    void Start()
    { 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePaddle(input.DetectTouch());
    }
    void MovePaddle(Vector3 toucPos)
    {
        direction.x = toucPos.x;
        if (direction.x!= 0)
        {
            RigidBody.AddForce(direction * Speed);
        }
    }
}
