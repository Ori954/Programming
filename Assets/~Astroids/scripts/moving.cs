using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{

    public class Moving : MonoBehaviour
    {
        //Member valibles 
        public float movementSpeed = 10;

        // Update is called once per frame
        void Update()
        {
            // if the player is pressing the up arrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                // Move the playter up by movement
                //    transform.position.y += movmentspeed;
            }

        }
    }
}
