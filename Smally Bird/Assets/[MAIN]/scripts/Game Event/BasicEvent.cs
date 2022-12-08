using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallyBird
{
    [CreateAssetMenu(fileName = "Basic Event", menuName ="Smally Bird/Game Events/Basic Event")]
    public class BasicEvent : ScriptableObject
    {
        private LinkedList<IBasicEventListener> listeners = new LinkedList<IBasicEventListener>();


        public void Register(IBasicEventListener listener)
        {
            listeners.AddLast(listener);
        }

        public void UnRegister(IBasicEventListener listener)
        {
            listeners.Remove(listener);
        }

        public void Raise()
        {
            foreach (var listener in listeners)
            {
                listener.Listen();
            }
        }
    }
}
