using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class RandomAxisPosSetter : MonoBehaviour
    {
        private enum Axis { X , Y, Z };

        [SerializeField]
        private Axis axis;

        [SerializeField]
        private float min = 13f;

        [SerializeField]
        private float max = 17f;

        [SerializeField]
        private bool setOnStart = false;

        private void Start()
        {
            if(setOnStart)
            {
                SetPos();
            }
        }

        public void SetPos()
        {
            switch (axis)
            {
                case Axis.X:
                    transform.localPosition = new Vector3(UnityEngine.Random.Range(min, max), transform.localPosition.y, transform.localPosition.z);
                    break;
                case Axis.Y:
                    transform.localPosition = new Vector3(transform.localPosition.x, UnityEngine.Random.Range(min, max), transform.localPosition.z);
                    break;
                case Axis.Z:
                    transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, UnityEngine.Random.Range(min, max));
                    break;
                default:
                    break;
            }
        }
    }
}
