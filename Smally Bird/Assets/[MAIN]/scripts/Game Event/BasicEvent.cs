using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    [CreateAssetMenu(fileName = "Basic Event", menuName ="Smally Bird/Game Events/Basic Event")]
    public class BasicEvent : ScriptableObject
    {
        private LinkedList<IBasicEventListener> listeners = new LinkedList<IBasicEventListener>();


        public bool IsRaised { get; private set; }

        public void Register(IBasicEventListener listener)
        {
            if(listeners.Count <= 0)IsRaised = false;
            listeners.AddLast(listener);
        }

        public void UnRegister(IBasicEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            if (!IsRaised) IsRaised = true;
            foreach (var listener in listeners)
            {
                listener.Listen();
            }
        }

    }
}
