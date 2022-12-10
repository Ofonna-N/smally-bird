using UnityEngine;

namespace SmallyBird
{
    public class EntityScroller : MonoBehaviour
    {
        [SerializeField]
        private ScrollingEntity[] scrollingEntities;

        [SerializeField]
        private int currentEntityIndex = 0;

        public void Scroll()
        {
            var currentEntity = scrollingEntities[currentEntityIndex];
            var neighborIndex = (currentEntityIndex >= scrollingEntities.Length - 1) ? 0 : currentEntityIndex + 1;

            currentEntity.SetNeighborPosition(scrollingEntities[neighborIndex]);

            currentEntityIndex = neighborIndex;
        }


    }
}