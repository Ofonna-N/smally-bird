using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    public class AxisPosResetter : MonoBehaviour
    {
        [SerializeField]
        private Transform axisPosSetterParent;

        [SerializeField]
        RandomAxisPosSetter[] axis;

        private void Start()
        {
            axis = axisPosSetterParent.GetComponentsInChildren<RandomAxisPosSetter>(true);
            SetAllPositions();
        }

        public void SetAllPositions()
        {
            for (int i = 0; i < axis.Length; i++)
            {
                axis[i].SetPos();
            }
        }
    }
}
