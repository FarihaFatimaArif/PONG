using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInput : MonoBehaviour
{
    Touch touch;
   // public GameObject ball;
    public float speedmod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DetectTouch2();
    }
    public Vector3 DetectTouch()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                //Debug.Log(touch.deltaPosition);
                return touch.deltaPosition;
            }
        }
        return Vector3.zero;
    }
    public void DetectTouch2()
    {
        if (Input.touchCount > 0)
        {
            
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("g");
               // ball.transform.position = new Vector2(transform.position.x + touch.deltaPosition.x * speedmod, transform.position.y);
            }
        }
    }
}
