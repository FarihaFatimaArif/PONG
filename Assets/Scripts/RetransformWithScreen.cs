using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RetransformWithScreen : MonoBehaviour
{
    [SerializeField] private Camera mianCam;
    [SerializeField] private GameObject[] walls;
    private float height;
    private float width;

     void Start()
    {
        height = mianCam.orthographicSize;
        width = mianCam.aspect * height;
        RetransformWalls();
    }

    void RetransformWalls()
    {
        walls[0].transform.position = new Vector3(0, height);
        walls[0].transform.localScale = new Vector3(width * 2, 0.5f);

        walls[1].transform.position = new Vector3(0, -height);
        walls[1].transform.localScale = new Vector3(width * 2, 0.5f);

        walls[2].transform.position = new Vector3(width, 0);
        walls[2].transform.localScale = new Vector3(height * 2, 0.5f);

        walls[3].transform.position = new Vector3(-width, 0);
        walls[3].transform.localScale = new Vector3(height * 2,0.5f);
    }
}
