using UnityEngine;

namespace SmallyBird
{
    [CreateAssetMenu(fileName ="Int Variable", menuName ="Smally Bird/Variables/Int Variable")]
    public class IntVariable : _AssetVariable
    {
        public int value;


        public void SetInt(int val)
        {
            value = val;
        }

    }
}
