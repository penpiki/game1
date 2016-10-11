using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {

	void TriggerEnter (Collider hit)
	{
		if (hit.gameObject.CompareTag ("Player")) {

			int sceneIndex = SceneManager.GetActiveScene ().buildIndex;

			SceneManager.LoadScene (sceneIndex);
		}
	}

}
