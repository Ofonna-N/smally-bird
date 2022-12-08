using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class TriggerDetector : _BasicDetector
    {
        

        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag(detectionTag))
            {
                _event.Raise();
            }
        }
    }
}
