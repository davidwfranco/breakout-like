﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePowerUpControllerNP : MonoBehaviour {

	protected Rigidbody2D rdb2d;
	private int vSpeed;

	// Use this for initialization
	void Awake () {
		rdb2d = GetComponent<Rigidbody2D>();
		vSpeed = GameControllerNP.instance.powerUpFallSpeed;
		rdb2d.velocity = Vector2.down * vSpeed;
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.GetComponent<Collider2D>().CompareTag("Player"))
		{
			Destroy(gameObject);
			ExecPowerUp(other);
		}
		else
		{
			if (other.GetComponent<Collider2D>().CompareTag("Floor"))
			{
				Destroy(gameObject);
			}
		}
	}

	protected virtual void ExecPowerUp(Collider2D other)
	{

	}

	void CleanLevel()
	{
		Destroy(gameObject);
	}
}