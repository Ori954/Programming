using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    //Member valibles 
    public float movementSpeed = 10;

	// Use this for initialization
	void Update()
    {
	
	// Update is called once per frame
	void Update ()
    {
		// if the player is pressing the up arrow
        if (input.Getkey(KeyCode.UpArrow))
            {
                // Move the playter up byyyyy mocement
                transform.position.y += movmentspeed
            }

	}
}
