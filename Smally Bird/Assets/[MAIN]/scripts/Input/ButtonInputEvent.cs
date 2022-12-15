using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SmallyBird
{
    public class ButtonInputEvent : MonoBehaviour
    {
        [SerializeField]
        private ButtonInput input;

        [SerializeField]
        private BasicEvent onInputEvent;

        private void OnInput(InputAction.CallbackContext ctx)
        {
            onInputEvent.Raise();
        }

        private void OnEnable()
        {
            input.SubscribeToAction(OnInput);
        }

        private void OnDisable()
        {
            input.UnSubscribeToAction(OnInput);
        }
    }
}
