using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class AddForce : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody rb;

        [SerializeField]
        private ForceMode forceMode;

        [SerializeField]
        private Vector3 force;


        public void Add()
        {
            rb.AddForce(force, forceMode);
        }
    }
}
