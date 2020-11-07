using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
	//accessing the rigidbody component of the player
	//making it private so it does not appear in the UI
	private Rigidbody2D reg;
	//public variable to adjust speed of the player 
	public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//initializing the rigidbody component 
		reg = GetComponent<Rigidbody2D>();
		//variable for the point we want to move to 
		var newX = 0f;
		var newY = 0f;
		if (Input.GetKey ("right")) { //when clicking the right button in keyboard 
			newX = speed;
		}
		reg.AddForce (new Vector2 (newX, newY));
	}
}
