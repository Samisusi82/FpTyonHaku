using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField] private int raylenght = 10;
    private DoorController interactiveObj;
    //mouse koe
    /**
    [SerializeField] private bool isMouseOn;

    [SerializeField] private UnityEvent mouseOnEvent;
    [SerializeField] private UnityEvent mouseOffEvent;
    /**/
    [SerializeField] private Image crosshair;

    private void Update()
    {
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, out RaycastHit hit, raylenght))
            {
                var raycastObj = hit.collider.gameObject.GetComponent<DoorController>();
                if (raycastObj != null)
                {
                    interactiveObj = raycastObj;
                    CrosshairChange(true);
                }
                else
                {
                    ClearInteraction();
                }
            }

            else
            {
                ClearInteraction();
            }

            if (interactiveObj != null)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    interactiveObj.InteractDoor();
                }
            }
        }
    }

    private void ClearInteraction()
    {
        if (interactiveObj != null)
        {
            CrosshairChange(false);
            interactiveObj = null;
        }
    }

    void CrosshairChange(bool on)
    {
        if (on)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
        }
    }
    //mouse koe
    /**
    void mouseOn(bool on)
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
    /**/
}
