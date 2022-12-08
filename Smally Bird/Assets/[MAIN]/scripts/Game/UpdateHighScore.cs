using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class UpdateHighScore : MonoBehaviour
    {
        [SerializeField]
        private ReferenceIntVariable score;

        [SerializeField]
        private ReferenceIntVariable highScore;


        public void SetHighScore()
        {
            if (score.GetValue() > highScore.GetValue())
            {
                highScore.SetValue(score.GetValue());
            }
        }
    }
}
