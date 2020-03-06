using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonUrks.Event.Sample
{
    public class UIMessage : MonoBehaviour
    {
        private UnityEngine.UI.Text text;

        void Start()
        {
            text = GetComponent<UnityEngine.UI.Text>();
        }

        void OnTriggerAreaEnter(Player player)
        {
            text.text = "Last event: Player enter!";
        }

        void OnTriggerAreaExit(Player player)
        {
            text.text = "Last event: Player exit!";
        }
    }
}
    
