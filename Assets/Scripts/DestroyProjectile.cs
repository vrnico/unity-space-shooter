﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	void Start () {

	}


	void Update () {

	}

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Projectile") {
			Destroy (transformCollision.gameObject);

		}
	}
}
