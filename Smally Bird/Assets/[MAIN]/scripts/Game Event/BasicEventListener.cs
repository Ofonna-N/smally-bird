using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace SmallyBird
{
    public class BasicEventListener : MonoBehaviour, IBasicEventListener
    {
        [SerializeField]
        private BasicEvent eventToListenTo;

        [SerializeField]
        private BasicEvent[] additionalEventsToListenTo;

        [SerializeField]
        private float delay = 0;

        [SerializeField]
        private bool runOnStart;

        [SerializeField]
        private bool listenOnce;

        [SerializeField, Tooltip("If selected events has been raised then this event listener stops listening for events")]
        private bool checkAgainstEvents;

        [SerializeField, Tooltip("Events to check against,")]
        private BasicEvent[] eventsToCheck;

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

        private void CheckForAdditionalEventsForRegistration( bool register)
        {
            if (additionalEventsToListenTo.Length > 0)
            {
                for (int i = 0; i < additionalEventsToListenTo.Length; i++)
                {
                    if (register)
                    {
                        additionalEventsToListenTo[i].Register(this);
                    }
                    else
                    {
                        additionalEventsToListenTo[i].UnRegister(this);
                    }
                }
            }
        }

        private void OnEnable()
        {
            eventToListenTo?.Register(this);
            CheckForAdditionalEventsForRegistration(true);
            
        }

        private void OnDisable()
        {
            eventToListenTo?.UnRegister(this);

            CheckForAdditionalEventsForRegistration(false);
        }

        void IBasicEventListener.Listen()
        {
            if (delay > 0)
            {
                StartCoroutine(AwaitListen());
            }
            else
            {
                OnListen();
            }
        }

        private void OnListen()
        {
            if (hasListened && listenOnce) return;

            if (checkAgainstEvents)
            {
                for (int i = 0; i < eventsToCheck.Length; i++)
                {
                    if (eventsToCheck[i].IsRaised) return;
                }
            }

            eventToCall?.Invoke();
            hasListened = true;
        }

        IEnumerator AwaitListen()
        {
            yield return new WaitForSeconds(delay);
            OnListen();
        }
    }
}
