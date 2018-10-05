using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformDown : MonoBehaviour {

	public float transformSpeed = 0.1f;
	void Start () {
		
	}
	

	void Update () {
		moveToBottom ();
	}

	void moveToBottom(){
		transform.Translate (0, -transformSpeed, 0);
	}
}
