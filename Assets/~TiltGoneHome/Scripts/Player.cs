using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{

    public class Player : MonoBehaviour
    {
        //Member valibles 
        public float movementSpeed = 10;

        private Rigidbody rigid;

        // Update is called once per frame
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }
        // Update is called once per frame
        void Update()
        {
            float InputH = Input.GetAxis("Horizontal");
            float InputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(InputH, 0, InputV);

            rigid.AddForce(inputDir * movementSpeed);
        }

    }
}