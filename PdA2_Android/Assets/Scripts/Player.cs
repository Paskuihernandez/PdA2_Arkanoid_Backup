using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public GameObject Player1;
    public GameObject Player2;

    public float movSpeed = 300;

    private Rigidbody2D playerBody;
    private float ScreenWidth;
    private float ScreenHeight;

    // Use this for initialization
    void Start () {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        playerBody = Player1.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch (i).position.y > ScreenHeight / 2)
            {
                RunCharacter(1.0f);
            }
            if(Input.GetTouch(i).position.y < ScreenHeight / 2)
            {
                RunCharacter(-1.0f);
            }
            i++;
        }

    }

    private void RunCharacter(float verticalInput)
    {
        playerBody.AddForce(new Vector2(verticalInput * movSpeed * Time.deltaTime, 0));
    }

}
