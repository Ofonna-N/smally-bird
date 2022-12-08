using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SmallyBird
{
    public class ScoreBinder : MonoBehaviour
    {
        [SerializeField]
        private IntVariable scoreVariable;

        [SerializeField]
        private TextMeshProUGUI scoreText_UI;

        //private void LateUpdate()
        //{
        //    scoreText_UI.text = $"Score:{scoreVariable.value}";
        //}


        public void BindScore()
        {
            scoreText_UI.text = $"Score: {scoreVariable.value}";
        }
    }
}
