using UnityEngine;
using UnityEngine.UIElements;


namespace SmallyBird
{
    public class ButtonBinder : _Binder
    {

        [SerializeField]
        private BasicEvent buttonClickEvent;

        public override void Bind()
        {
            (element as Button).clicked += () =>
            {
                buttonClickEvent?.Raise();
            };
        }

    }
}