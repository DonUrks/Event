using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonUrks.Event.Sample
{
    public class Player : MonoBehaviour
    {
        public float translateSpeed;
        public float rotateSpeed;

        public GameEvent triggerAreaEnter;
        public GameEvent triggerAreaExit;

        void Update()
        {
            var move = Time.deltaTime * translateSpeed * Input.GetAxis("Vertical");
            transform.Translate(new Vector3(0, 0, move), Space.Self);

            var angle = Time.deltaTime * rotateSpeed * Input.GetAxis("Horizontal");
            transform.Rotate(new Vector3(0, 1, 0), angle);
        }

        private void OnTriggerEnter(Collider other)
        {
            triggerAreaEnter?.Raise(this);
        }

        private void OnTriggerExit(Collider other)
        {
            triggerAreaExit?.Raise(this);
        }
    }
}