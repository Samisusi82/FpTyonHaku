using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseOn : MonoBehaviour
{
    [SerializeField] private bool isMouseOn;

    [SerializeField] private UnityEvent mouseOnEvent;
    [SerializeField] private UnityEvent mouseOffEvent;

    public void mouseOn()
    {
        if (!isMouseOn)
        {
            isMouseOn = true;
            mouseOnEvent.Invoke();
        }

        else
        {
            isMouseOn = false;
            mouseOffEvent.Invoke();
        }
    }
}
