using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireEvent_OnAnimationEvent : MonoBehaviour
{
    public UnityEvent triggeredEvents;


    public void TriggerEvents()
    {
        triggeredEvents.Invoke();
    }
}
