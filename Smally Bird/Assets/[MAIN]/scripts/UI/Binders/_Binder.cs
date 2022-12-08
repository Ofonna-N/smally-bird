using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace SmallyBird
{
    public abstract class _Binder : MonoBehaviour
    {

        [SerializeField]
        private UIDocument uIDocument;


        [SerializeField]
        private string elementID;
       

        protected VisualElement element;

        [SerializeField]
        private bool bindOnQuery = true;


        private void OnEnable()
        {
            Query();
            if(bindOnQuery)Bind();
        }

        private void Query()
        {
            element = uIDocument.rootVisualElement.Q<VisualElement>(elementID);
        }

        public abstract void Bind();
    }
}
