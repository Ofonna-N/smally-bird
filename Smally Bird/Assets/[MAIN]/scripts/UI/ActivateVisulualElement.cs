using UnityEngine;
using UnityEngine.UIElements;


namespace SmallyBird
{
    public class ActivateVisulualElement : MonoBehaviour
    {
        [SerializeField]
        private UIDocument uIDocument;

        [SerializeField]
        private string elementID = "game-over-panel";

        private VisualElement element;

        private void OnEnable()
        {
            element = uIDocument.rootVisualElement.Q<VisualElement>(elementID);
        }

        public void SetActive(bool activate)
        {
            element.style.display = (activate)? DisplayStyle.Flex : DisplayStyle.None;
        }
    }
}
