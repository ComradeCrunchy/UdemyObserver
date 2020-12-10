using System;
using UnityEngine.Events;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityEvent response;

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unredgister(this);
    }

    public void OnEventOccurs()
    {
        response.Invoke();
    }
}
