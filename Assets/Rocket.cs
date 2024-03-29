﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }
    private void ProcessInput()
    { 
        if(Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        else
            {
                audioSource.Stop();
            }
        }
        if (Input.GetKey(KeyCode.A))
            {
                print("Left");
                transform.Rotate(Vector3.forward);
            }
        if (Input.GetKey(KeyCode.D))
            {
                print("Right");
                transform.Rotate(-Vector3.forward);
            }
    }
}
