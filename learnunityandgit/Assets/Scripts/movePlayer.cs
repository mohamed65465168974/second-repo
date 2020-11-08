using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
	//accessing the rigidbody component of the player
	//making it private so it does not appear in the UI
	private Rigidbody2D reg;
	//public variable to adjust speed of the player 
	public float speed = 10f;
	//checking if the player is standing or not 
	public bool standing;
	public float speedSlow = 0.3f;
	//determing the maximum velocity of the player 
	public Vector2 MaxVelocity = new Vector2(2,3);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//initializing the rigidbody component 
		reg = GetComponent<Rigidbody2D>();
		float forceX = Mathf.Abs (reg.velocity.x);
		float forceY = Mathf.Abs (reg.velocity.y);
		if (forceY < 0.2f)  //if the player is standing 
			standing = true;
		else
			standing= false;
		
		//variable for the point we want to move to 
		var newX = 0f;
		var newY = 0f;
		if (Input.GetKey ("right")) { //when clicking the right button in keyboard 
			//maximum speed for x is 2 if above do not increase the speed 
			if(forceX<MaxVelocity.x)
			newX = standing? speed:speed*speedSlow; //if the player standing move in normal speed and if it is already moving reduce it is speed 
			transform.localScale = new Vector3 (1, 1, 1);
		}
		else if (Input.GetKey ("left")) { //when clicking the left button in keyboard 
			//maximum speed for x is 2 if above do not increase the speed 
			if(forceX<MaxVelocity.x)
			newX = standing? -speed:-speed*speedSlow; //if the player standing move in normal speed and if it is already moving reduce it is speed 
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		else if (Input.GetKey ("up")) { //when clicking the up button in keyboard 
			//maximum speed for y is 3 if above do not increase the speed
			if(forceY<MaxVelocity.y)
			newY = speed;
		}
		reg.AddForce (new Vector2 (newX, newY));
	}
}
