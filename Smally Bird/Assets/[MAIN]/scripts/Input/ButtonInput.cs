using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace SmallyBird
{
    [CreateAssetMenu(fileName ="Button Input", menuName ="Smally Bird/Input Actions/Button Input")]
    public class ButtonInput : ScriptableObject
    {
        [SerializeField]
        private InputAction buttonAction;


        public void SubscribeToAction(Action<InputAction.CallbackContext> action)
        {
            buttonAction.performed += action;
        }

        public void UnSubscribeToAction(Action<InputAction.CallbackContext> action)
        {
            buttonAction.performed -= action;
        }

        private void OnEnable()
        {
            buttonAction?.Enable();
        }

        private void OnDisable()
        {
            buttonAction?.Disable();
        }
    }
}
