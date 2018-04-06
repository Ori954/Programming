using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onTriggered;

        //references"

        private SpriteRenderer need;
        private Rigidbody2D rigid;


        // Runs function when collider enters trigger (Goal)
        void OnTriggerEnter(Collider other)
        {
            // Check if other is "Player"
            if (other.name == "Player")
            {
                // Run 'onTriggered' event
                onTriggered.Invoke();
            }
        }
    }
}
