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

        [SerializeField]
        private bool canJump = true;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }


        public void Jump(InputAction.CallbackContext ctx)
        {
            //Console.WriteLine("Jump");
            if (!canJump) return;
            if(rb.isKinematic)rb.isKinematic = false;
            rb.velocity = new Vector3(0f, 0f, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        public void SetCanJump(bool value)
        {
            canJump = value;
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
