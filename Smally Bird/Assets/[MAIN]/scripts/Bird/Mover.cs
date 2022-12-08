using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    [RequireComponent(typeof(Rigidbody))]
    public class Mover : MonoBehaviour
    {
        private Rigidbody rb;

        [SerializeField]
        private Vector3 moveDirection;

        [SerializeField]
        private float moveSpeed = 5f;


        [SerializeField]
        private bool canMove = false;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (canMove && !rb.isKinematic)
            {
                Move();
            }
        }

        public void Move()
        {
            var dir = moveDirection * moveSpeed;
            //rb.velocity = new Vector3(rb.velocity.x + dir.x, rb.velocity.y + dir.y, rb.velocity.z + dir.z);
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
        }

        public void SetCanMove(bool canMove)
        {
            this.canMove = canMove;
        }
    }
}
