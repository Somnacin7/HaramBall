using UnityEngine;
using System.Collections;

public class PortalIn : MonoBehaviour {

    public Transform teleOut;
	void Start () {

    }
	void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            Vector3 newPos = teleOut.position;
            player.transform.position = newPos;
        }
    }
}
