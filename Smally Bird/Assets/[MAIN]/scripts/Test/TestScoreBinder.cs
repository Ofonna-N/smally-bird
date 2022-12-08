using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace SmallyBird
{
    public class TestScoreBinder : MonoBehaviour
    {
        [SerializeField]
        private UIDocument uIDocument;

        [SerializeField]
        private IntVariable scoreVariable;

        private Label scoreLabel;


        private void OnEnable()
        {
            scoreLabel = uIDocument.rootVisualElement.Q<Label>("score");
        }

        public void BindScore()
        {
            scoreLabel.text = $"score: {scoreVariable.value}";
        }
    }
}
