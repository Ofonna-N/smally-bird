using UnityEngine;
using UnityEngine.UIElements;


namespace SmallyBird
{
    public class ActivatePanel : MonoBehaviour
    {
        [SerializeField]
        private UIDocument uIDocument;

        [SerializeField]
        private string panelId = "game-over-panel";

        private VisualElement panel;

        private void OnEnable()
        {
            panel = uIDocument.rootVisualElement.Q<VisualElement>(panelId);
        }

        public void SetActive(bool activate)
        {
            panel.style.display = DisplayStyle.Flex;
        }
    }
}
