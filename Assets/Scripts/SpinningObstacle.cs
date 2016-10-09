using UnityEngine;
using System.Collections;

public class SpinningObstacle : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (0, Time.deltaTime * 10 * speed, 0);
		transform.Rotate (rotation);
	}
}
