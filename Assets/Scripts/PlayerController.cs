﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rdb2d;
	private Vector2 rawPosition;
	private Vector2 targetPotision;
	private float targetWidth;
	private GameController gControl;
	public float moveSpeed;
	private float moveHDir;

	// Use this for initialization
	void Start () {
		rdb2d = GetComponent<Rigidbody2D>();
		gControl = GameController.instance;
	}
	
	// Update is called once per physics timestamp
	void FixedUpdate () {
		if (!gControl.gameOver) {
			moveHDir = Input.GetAxisRaw("Horizontal");
			rdb2d.velocity = new Vector2((moveSpeed * moveHDir), 0);

			//keyboard control
			// if (Input.GetKey("left")) 
			// {
			// 	rdb2d.velocity = new Vector2(-5, 0);
			// }
			// else if (Input.GetKey("right")) 
			// {
			// 	rdb2d.velocity = new Vector2(5, 0);				
			// }
			// else 
			// {
			// 	rdb2d.velocity = Vector2.zero;
			// }
			//mouse pointer control
			// rawPosition = gControl.cam.ScreenToWorldPoint (Input.mousePosition);
			// targetPotision = new Vector2 (rawPosition.x, rdb2d.position.y);

		} else {
			rdb2d.MovePosition (new Vector2 (0.0f, rdb2d.position.y));
		}
	}

	/// Sent when another object leaves a trigger collider attached to
	/// this object (2D physics only).
	void OnTriggerExit2D(Collider2D other)
	{
		this.
	}
}
