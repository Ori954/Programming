using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 5f;
        public int health = 100;
        public int damage = 50;
        public float maxVelocity = 5f;
        public float maxSlopeangle = 25f;
        [Tooltip("The maximum speed a player can move.")]
        public float rayDistance = .25f;
        public bool isGrounded = false;
        public bool isOnSlope = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}