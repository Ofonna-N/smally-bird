using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class CollisionDetector : _BasicDetector
    {

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.CompareTag(detectionTag))
            {
                //Debug.Log("Hit " + detectionTag);
                _event.Raise();
            }
        }
    }
}
