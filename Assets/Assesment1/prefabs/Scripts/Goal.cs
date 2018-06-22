using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace TiltGoneHome
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
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene("Level_02");
            }
            // Check if other is "Player"
            if (other.name == "Player")
            {
                // Run 'onTriggered' event
                onTriggered.Invoke();
            }
        }
    }
}
