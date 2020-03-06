using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonUrks.Event
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "DonUrks/GameEvent")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listernes = new List<GameEventListener>();

        public void Raise(Object sender)
        {
            foreach(var listener in this.listernes)
            {
                listener.OnEventRaised(sender);
            }
        }

        public void Register(GameEventListener listener)
        {
            this.listernes.Add(listener);
        }

        public void Unregister(GameEventListener listener)
        {
            this.listernes.Remove(listener);
        }
    }
}