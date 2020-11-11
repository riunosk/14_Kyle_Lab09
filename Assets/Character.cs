﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int moveSpeed;
    public int rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
		{
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
        if (Input.GetKey(KeyCode.S))
		{
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
		}
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -Time.deltaTime * rotateSpeed, 0));
        }
    }
}
