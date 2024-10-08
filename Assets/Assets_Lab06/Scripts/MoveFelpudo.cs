﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFelpudo : MonoBehaviour
{
	public Vector3 moveSpeed;
	public float spawnTime = 2f;
	public float spawnDelay = 2f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		moveSpeed = Vector3.right * Time.deltaTime;
		//InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
	}

	void ChangeSpeed()
	{
		moveSpeed = new Vector3(Random.Range(2, 1), 0, 0) * 0.03f;

	}

	// Update is called once per frame
	void Update()
	{
		transform.position += moveSpeed;
	}

	private void OnCollisionEnter2D(Collision2D collision) {
		rb.velocity = Vector3.zero;
		
	}
}