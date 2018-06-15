using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public Vector2[] directions =
        {
        new Vector2(-1, 1),
        new Vector2(1, 1)
    };

        private Ball currentBall;

        // Use this for initialization
        void Start()

        {
            currentBall = GetComponentInChildren<Ball>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}