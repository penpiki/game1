using UnityEngine;
using System.Collections;

public class PlayerDestroy : MonoBehaviour {

	void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) {
			Destroy (gameObject);
			Destroy (hit.gameObject);
		}

	}
}
