using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour {


	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;
	public GameObject LoserLabelObject;
	public GameObject Button;
	public GameObject Camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		int count = GameObject.FindGameObjectsWithTag ("Enemy").Length;
	

		int survive = GameObject.FindGameObjectsWithTag ("Player").Length;

		scoreLabel.text = count.ToString ();

		//負け処理
		if (survive == 0) {

			LoserLabelObject.SetActive (true);
			Button.SetActive (true);
			Camera.SetActive (true);
		}


	    //勝ち処理
		if (count == 0) {

			winnerLabelObject.SetActive (true);
			Button.SetActive (true);



		
		}
	}
}
