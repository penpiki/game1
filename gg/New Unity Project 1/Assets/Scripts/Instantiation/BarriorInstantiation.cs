using UnityEngine;
using System.Collections;

public class BarriorInstantiation : MonoBehaviour {

	public GameObject barrior;
	public int NumofBarrior;
	public Quaternion rotation = Quaternion.identity;

	void Start () {

		for (int a = 0; a < NumofBarrior; a++){
			Vector3 position = new Vector3 (Random.Range (-15f, 15f), 1, Random.Range (-15f, 15f));

			rotation.eulerAngles = new Vector3 (0,Random.Range (-180f, 180f), 0);
			Instantiate (barrior, position, rotation);
		}
	}


}