using UnityEngine;
using UnityEngine.Events;

namespace SmallyBird
{
    public class ScrollingEntity : MonoBehaviour
    {


        [SerializeField]
        private Transform neighborNewPos;

        [SerializeField]
        private UnityEvent onScroll;

        public void SetNeighborPosition(ScrollingEntity neighbor)
        {
            neighbor.SetPos(neighborNewPos);
        }

        public void SetPos(Transform newPos)
        {
            transform.position = newPos.position;
            onScroll?.Invoke();
        }
    }
}
