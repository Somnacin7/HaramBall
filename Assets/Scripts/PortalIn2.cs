using UnityEngine;
using System.Collections;

public class PortalIn2 : MonoBehaviour {
    private GameObject player;
    private GameObject portalOut;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        portalOut = GameObject.FindGameObjectWithTag("portal_out2");
        
    }
	void OnTriggerEnter(Collider player)
    {

        Vector3 newPos=portalOut.transform.position+ Vector3.up;
        player.transform.position = newPos;
    }
}
