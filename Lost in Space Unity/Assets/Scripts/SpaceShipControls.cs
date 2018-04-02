using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControls : MonoBehaviour {

	public Rigidbody2D rb;
	public float thrust;
	public float turnThrust;
	private float thrustInput;
	private float turnInput;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Check input from the keyboard and apply thrust
		thrustInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");

	}

	void FixedUpdate()
	{
		rb.AddRelativeForce (Vector2.up * thrustInput);
	}

}