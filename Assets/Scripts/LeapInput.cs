﻿using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class LeapInput : MonoBehaviour
{
    public Transform stage;
    public Transform player;
    LeapServiceProvider provider;
    public bool isDebug = false;

    // Use this for initialization
    void Start()
    {
        provider = FindObjectOfType<LeapServiceProvider>() as LeapServiceProvider;

        if (!isDebug)
        {
            player.parent = stage;
            player.GetComponent<Rigidbody>().isKinematic = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = provider.CurrentFrame;

        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsRight)
            {
                if (player.parent != null)
                {
                    Invoke("UnparentPlayer", 2);
                }
                var handRotation = hand.Rotation.ToQuaternion();
                stage.rotation = handRotation;
            }
        }
    }

    void UnparentPlayer()
    {
        player.parent = null;
        player.GetComponent<Rigidbody>().isKinematic = false;
    }
}
