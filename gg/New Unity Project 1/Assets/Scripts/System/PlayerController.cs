using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float speed = 6.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
	public float rotationspeed = 10f;
	public float crabspeed = 5f;
	private Vector3 moveDirection = Vector3.zero;

	void Update(){
		CharacterController controller = GetComponent<CharacterController> ();
		if (controller.isGrounded) {
			if (Input.GetKey ("q") || Input.GetKey ("e")) {

				moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
				moveDirection = transform.TransformDirection (moveDirection);
				moveDirection *= speed;
			} else {
				moveDirection = new Vector3 (0, 0, Input.GetAxis ("Vertical"));
				moveDirection = transform.TransformDirection (moveDirection);
				moveDirection *= speed;
			}
			if (Input.GetButton ("Jump"))
				moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);

		if ((Input.GetKey ("q") || Input.GetKey ("e") || Input.GetKeyUp("q") || Input.GetKeyUp("e")) == false) {
			transform.Rotate (0, rotationspeed * Time.deltaTime * Input.GetAxis ("Horizontal"), 0);
		}

	}

}