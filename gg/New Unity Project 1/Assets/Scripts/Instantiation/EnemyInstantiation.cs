using UnityEngine;
using System.Collections;

public class EnemyInstantiation : MonoBehaviour {

	public GameObject enemy;
	public int NumofEnemy;
	public Quaternion rotation = Quaternion.identity;

	void Start () {
	
		for (int a = 0; a < NumofEnemy; a++){
		Vector3 position = new Vector3 (Random.Range (-22f, 22f), 1, Random.Range (-22f, 22f));

			rotation.eulerAngles = new Vector3 (0,Random.Range (-180f, 180f), 0);
				Instantiate (enemy, position, rotation);
		}
	}


}
