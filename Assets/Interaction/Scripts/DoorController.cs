using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    [SerializeField] private bool isDoorOpen;

    [SerializeField] private UnityEvent openDoorEvent;
    [SerializeField] private UnityEvent closeDoorEvent;

    public void InteractDoor()
    {
        if (!isDoorOpen)
        {
            isDoorOpen = true;
            openDoorEvent.Invoke();
        }
        else
        {
            isDoorOpen = false;
            closeDoorEvent.Invoke();
        }
    }
}
