﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverAudio : MonoBehaviour {

    public AudioSource jetSound;
    private float jetPitch;
    private const float LowPitch = 0.1f;
    private const float HighPitch = 2.0f;
    private const float SpeedToRevs = 0.01f;
    Vector3 myVelocity;
    Rigidbody carRigidbody;

	// Use this for initialization
	void Awake () {
        carRigidbody = GetComponent<Rigidbody>();

	}

    private void FixedUpdate()
    {
        myVelocity = carRigidbody.velocity;
        float forwardSpeed = transform.InverseTransformDirection(carRigidbody.velocity).z;
        float engineRevs = Mathf.Abs(forwardSpeed) * SpeedToRevs;
        jetSound.pitch = Mathf.Clamp(engineRevs, LowPitch, HighPitch);
    }

}
