using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {

	void OnTriggerEnter (Collider hit){
		if (hit.CompareTag("Quad")){
			Destroy(gameObject) ;
		 		}
			}
}
