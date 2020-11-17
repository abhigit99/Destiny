using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float force = 10f;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddRelativeForce(new Vector3(-speed, 0, 0));

    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddRelativeForce(new Vector3(0,0,-force));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddRelativeForce(new Vector3(0, 0, force));
        }
    }
}