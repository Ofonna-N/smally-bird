using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

namespace SmallyBird
{
    [RequireComponent(typeof(Rigidbody))]
    public class Jumper : MonoBehaviour
    {
        private Rigidbody rb;

        [SerializeField]
        private ButtonInput jumpInput;

        [SerializeField]
        private float jumpForce = 20f;


        private void Start()
        {
            rb = GetComponent<Rigidbody>();

        }


        public void Jump(InputAction.CallbackContext ctx)
        {
            //Console.WriteLine("Jump");
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        private void OnEnable()
        {
            jumpInput.SubscribeToAction(Jump);
        }

        private void OnDisable()
        {
            jumpInput.UnSubscribeToAction(Jump);
        }
    }
}
