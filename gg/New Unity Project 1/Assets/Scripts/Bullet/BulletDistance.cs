using UnityEngine;
using System.Collections;

public class BulletDistance : MonoBehaviour {



	void Update () {
	
		Vector3 a = new Vector3 (0, 0, 0);

		float dist = Vector3.Distance (a, transform.position);

		if (dist > 40.0)
			Destroy (gameObject);
			

	}
}
