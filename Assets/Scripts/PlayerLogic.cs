using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {

	public float playerSpeed =1.0f;

	float maxPlayerXDistance = 25.0f;

	public float shootingSpeed = 0.5f;

	public bool isShooting = true;

	float projectileCollisionOffset = 4.0f;

	public GameObject projectile;

	void Start () {
		StartCoroutine (projectileShootTimer ());
	}
	

	void Update () {
		playerMovement ();
	}

	void playerMovement() {
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)  && transform.position.x >= -maxPlayerXDistance) {
			transform.Translate (-playerSpeed, 0, 0);
		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow) && transform.position.x <= maxPlayerXDistance) {
			transform.Translate (playerSpeed, 0, 0);
		}
	}

	IEnumerator projectileShootTimer(){

		while (isShooting == true) {
			spawnProjectile ();
			yield return new WaitForSeconds (shootingSpeed);
		}
	}

	void spawnProjectile(){
		Instantiate (projectile, new Vector3(transform.position.x, transform.position.y + projectileCollisionOffset, 0), Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D tempCollision){
		if (tempCollision.gameObject.tag == "Collision") {
			SceneManager.LoadScene ("gameprototyping");
		}

	}
}
