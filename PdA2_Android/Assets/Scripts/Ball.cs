using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    int direccionX;
    int direccionY;

    float speed;


	// Use this for initialization
	void Start () {

        speed = Random.Range(10, 15);

        direccionX = Random.Range(0, 2);
        if (direccionX == 0)
        {
            direccionX = 1;
        }
        else
        {
            direccionX = -1;
        }

        direccionY = Random.Range(0, 2);
        if (direccionY == 0)
        {
            direccionY = 1;
        }
        else
        {
            direccionY = -1;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * direccionX, speed * direccionY);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
