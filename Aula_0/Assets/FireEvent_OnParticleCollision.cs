using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireEvent_OnParticleCollision : MonoBehaviour
{
    public UnityEvent triggeredEvents;

    private void OnParticleCollision() 
    {
        triggeredEvents.Invoke();
    }
}
