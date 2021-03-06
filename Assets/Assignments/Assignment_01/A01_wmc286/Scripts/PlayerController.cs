﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wmc286
{
    public class PlayerController : MonoBehaviour
    {
        // Code below found on Unity Roll a Ball tutorial
        private Rigidbody rb;
        public float speed;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }
    }
}