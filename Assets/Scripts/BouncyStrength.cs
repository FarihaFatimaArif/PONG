using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyStrength : MonoBehaviour
{
    public float Bounciness;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.Bounciness);
        }
    }
}
