using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class IntAdder : MonoBehaviour
    {
        [SerializeField]
        private ReferenceIntVariable scoreVariable;

        public void Add(int value)
        {
            var newValue = scoreVariable.GetValue() + value;
            scoreVariable.SetValue(newValue);
        }
    }
}
