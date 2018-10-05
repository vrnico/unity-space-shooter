using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {

	public GameObject particles;
	ScoreLogic addToScore;

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Collision") {

			spawnParticle (transformCollision.transform.position);

			Destroy (transformCollision.gameObject);

			callScoreLogicScript ();

		}
	}

	void callScoreLogicScript(){


		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic> ();

		addToScore.addToScoreVOID ();
	}

	void spawnParticle(Vector2 tempPosition){
		Instantiate (particles, tempPosition, Quaternion.identity);
	}
}
