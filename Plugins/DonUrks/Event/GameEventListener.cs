using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonUrks.Event
{ 
    public class GameEventListener : MonoBehaviour
    {
        public enum MessageType
        {
            None,
            SendMessage,
            BroadcastMessage
        }

        public GameEvent Event;
        public MessageType messageType = MessageType.BroadcastMessage;
        public UnityEngine.Events.UnityEvent Response;

        private void OnEnable()
        {
            Event.Register(this);
        }

        private void OnDisable()
        {
            Event.Unregister(this);
        }

        public void OnEventRaised(Object sender)
        {
            Response?.Invoke();

            var methodName = "On" + Event.name;
            switch (messageType)
            {
                case MessageType.BroadcastMessage:
                    BroadcastMessage(methodName, sender, SendMessageOptions.DontRequireReceiver);
                    break;
                case MessageType.SendMessage:
                    SendMessage(methodName, sender, SendMessageOptions.DontRequireReceiver);
                    break;
                default:
                    break;
            }
        }
    }
}