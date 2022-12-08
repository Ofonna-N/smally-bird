//using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace SmallyBird
{
    public class IntBinder : _Binder
    {
        [SerializeField]
        protected string prefix;

        [SerializeField]
        private ReferenceIntVariable intVariable;


        public override void Bind()
        {
            (element as Label).text = prefix + intVariable.GetValue().ToString();
        }
    }
}
