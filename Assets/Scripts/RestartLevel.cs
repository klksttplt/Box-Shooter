﻿using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// call the RestartGame function in the game manager
			GameManager.gm.RestartGame();
		}
	}
}
