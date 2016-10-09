using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	private Rigidbody rb;
	public GameObject player;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame - game code
	void Update () {

	}

	// called before physics calculations - physics code
	void FixedUpdate() {

		float rotateX = Input.GetAxis ("Vertical");
		float rotateZ = -1 * Input.GetAxis ("Horizontal");

		// Use this to rotate around player point
		//Vector3 axisX = new Vector3 (1, 0, 0);
		//Vector3 axisZ = new Vector3 (0, 0, 1);
		//Vector3 playerPoint = new Vector3 (player.transform.position.x, 0, player.transform.position.z);
		//transform.RotateAround (playerPoint, axisX, rotateX);
		//transform.RotateAround (playerPoint, axisZ, rotateZ);

		// Use this to rotate around origin
		Vector3 rotation = new Vector3 (rotateX, 0, rotateZ);
		transform.Rotate (rotation);

	}
}
