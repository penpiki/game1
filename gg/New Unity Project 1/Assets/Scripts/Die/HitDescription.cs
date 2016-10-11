using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitDescription : MonoBehaviour
{
	// オブジェクトと接触した時に呼ばれるコールバック
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		// 接触したオブジェクトのタグが"Player"の場合
		if (hit.gameObject.CompareTag ("Danger")) {

			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			// 現在のシーンを再読込する
			SceneManager.LoadScene(sceneIndex);
		}

			// 現在のシーン番号を取得
		}
	}
