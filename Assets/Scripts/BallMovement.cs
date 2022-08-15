using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    float speed = 150;
    // Start is called before the first frame update
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
    }
    public void MoveBall()
    {
        float x = Random.value < 0.5 ? -1 : 1;
        float y = Random.value < 0.5 ? Random.Range(-2, -1) : Random.Range(1, 2);
        Vector2 direction = new Vector2(x, y);
        rigidBody.AddForce(direction * speed);
    }
    public void AddForce(Vector2 force)
    {
        rigidBody.AddForce(force);
    }
    public void ResetBall()
    {
        rigidBody.position = Vector2.zero;
        rigidBody.velocity = Vector2.zero;
    }
}
