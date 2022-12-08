using UnityEngine;
using UnityEngine.Events;

namespace SmallyBird
{
    public class BasicEventListener : MonoBehaviour, IBasicEventListener
    {
        [SerializeField]
        private BasicEvent eventToListenTo;

        [SerializeField]
        private bool runOnStart;

        [SerializeField]
        private bool listenOnce;

        [SerializeField]
        private UnityEvent eventToCall;

        private bool hasListened;

        private void Start()
        {
            if (runOnStart)
            {
                (this as IBasicEventListener).Listen();
            }
        }

        private void OnEnable()
        {
            eventToListenTo?.Register(this);
        }

        private void OnDisable()
        {
            eventToListenTo?.UnRegister(this);
        }

        void IBasicEventListener.Listen()
        {
            if (hasListened && listenOnce) return;
            eventToCall?.Invoke();
            hasListened = true;
        }
    }
}
