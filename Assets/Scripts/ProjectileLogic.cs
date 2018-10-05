using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour {

	public float transformSpeed = 0.8f;

	void Start () {
		
	}
	

	void Update () {
		moveTransformToTop ();
	}

	void moveTransformToTop() {
		transform.Translate (0, transformSpeed, 0);
	}


}
