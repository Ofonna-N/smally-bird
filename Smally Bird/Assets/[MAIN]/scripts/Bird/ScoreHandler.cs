using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class ScoreHandler : MonoBehaviour
    {
        [SerializeField]
        private IntVariable scoreVariable;

        public void AddScore(int value)
        {
            scoreVariable.value += value;
        }
    }
}
