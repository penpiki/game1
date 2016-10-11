using UnityEngine;
using System.Collections;

public class EnemyBehaviour: MonoBehaviour {

	public Rigidbody bullet;
	public float speed = 10f;
	public CharacterController player;
	public GameObject enemy;

	void FireBullet(){

		Rigidbody bulletClone = (Rigidbody) Instantiate (bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.forward * speed;
	}

	void Update(){


		Vector3 playerposition = player.transform.position;
		Vector3 position = transform.position;
		float angle = Vector3.Angle (position, playerposition);
		enemy.transform.Rotate (0, angle, 0);


		if (Random.value <0.025 ) {
			FireBullet ();
		}
	}
}