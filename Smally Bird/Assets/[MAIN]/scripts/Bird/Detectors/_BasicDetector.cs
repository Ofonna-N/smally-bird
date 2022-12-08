using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public abstract class _BasicDetector : MonoBehaviour
    {
        [SerializeField]
        protected BasicEvent _event;

        [SerializeField]
        protected string detectionTag;

    }
}
