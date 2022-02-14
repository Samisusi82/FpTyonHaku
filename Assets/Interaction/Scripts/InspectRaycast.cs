using UnityEngine;
using UnityEngine.UI;
public class InspectRaycast : MonoBehaviour
{
    [SerializeField] private int rayLenght = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    private ObjectController raycastedObj;

    [SerializeField] private Image crosshair;
    private bool isCrosshairActive;
    private bool doOnce;

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);


        if (Physics.Raycast(transform.position, fwd, out hit, rayLenght, layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("InteractObject"))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                    raycastedObj.ShowObjectName();
                    raycastedObj.ShowExtraInfo();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;
                /**
                if (Input.GetMouseButtonDown(0))
                {
                    raycastedObj.ShowExtraInfo();
                }
                /**/
            }
        }
        else
        {
            if (isCrosshairActive)
            {
                raycastedObj.HideObjectName();
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool on)
    {
        if (on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}
