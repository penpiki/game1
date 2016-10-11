using UnityEngine;
using System.Collections;

public class BulletFire : MonoBehaviour {

	public Rigidbody bullet;
	public float speed = 10f;

	void FireBullet(){

		Rigidbody bulletClone = (Rigidbody) Instantiate (bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.forward * speed;
	}

	void Update(){
		if (Input.GetButtonDown ("Fire1")) {


			FireBullet ();
		}
	}
}
