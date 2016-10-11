using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	void OnTriggerEnter (Collider hit){
		if (hit.CompareTag ("Enemy")) {
			Destroy (gameObject);
			Destroy (hit.gameObject);
		}
	}
}
