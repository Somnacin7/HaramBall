using UnityEngine;
using System.Collections;

public class VictoryDetector : MonoBehaviour
{

    void Start()
    {

    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            //Victory stuff
        }
    }
}