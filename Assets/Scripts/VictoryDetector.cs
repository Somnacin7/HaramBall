using UnityEngine;
using System.Collections;

public class VictoryDetector : MonoBehaviour {

	public GameObject victory;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other == victory.GetComponent<Collider>()) {
			// ball has readched the victory square
			int level = Application.loadedLevel;
			Application.LoadLevel (level + 1);
		}
	}
}
