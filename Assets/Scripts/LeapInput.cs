using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class LeapInput : MonoBehaviour
{
    public Transform stage;
    LeapServiceProvider provider;

    // Use this for initialization
    void Start()
    {
        provider = FindObjectOfType<LeapServiceProvider>() as LeapServiceProvider;
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = provider.CurrentFrame;

        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsRight)
            {
                var handRotation = hand.Rotation.ToQuaternion();
                stage.rotation = handRotation;
            }
        }
    }
}
