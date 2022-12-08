using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace SmallyBird
{

    [System.Serializable]
    public abstract class ReferenceVariable<T>
    {
        public enum Type { _static, _asset };

        [SerializeField]
        protected Type type;

        [SerializeField]
        protected _AssetVariable variable_asset;

        [SerializeField]
        protected T variable_static;


        public abstract T GetValue();

        public abstract void SetValue(T value);
    }


    [System.Serializable]
    public class ReferenceIntVariable : ReferenceVariable<int>
    {
        //[SerializeField]
        //protected int variable_static;


        public override int GetValue()
        {
            switch (type)
            {
                case Type._static:
                    return variable_static;
                case Type._asset:
                    return (variable_asset as IntVariable).value;
                default:
                    return variable_static;
            }
        }

        public override void SetValue( int value)
        {
            switch (type)
            {
                case Type._static:
                    variable_static = value;
                    break;
                case Type._asset:
                    (variable_asset as IntVariable).value = value;
                    break;
                default:
                    break;
            }
        }
    }
}