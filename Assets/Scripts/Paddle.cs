using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    protected float Speed=8;
    protected Rigidbody2D RigidBody; 
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        
    }
    public void ResetPaddle()
    {
        RigidBody.velocity = Vector2.zero;
        RigidBody.position = new Vector2( 0, RigidBody.position.y);
    }
}
