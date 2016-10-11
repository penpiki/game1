using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnButton : MonoBehaviour {

	public void OnClick(){
		int sceneIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (sceneIndex);
	}
}
