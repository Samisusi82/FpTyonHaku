using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private string itemName;

    [TextArea] [SerializeField] private string itemExtraInfo;

    [SerializeField] private InspectController inspectController;

    public Animator animator;

    private Animator doorAnim;

    private bool doorOpen = false;



    /**
    public void ToggleBool(string boolname)
    {
        animator.SetBool(boolname, !animator.GetBool(boolname));
    }
    /**/
    
    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnim.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
        }

    }
   

    public void ShowObjectName()
    {
        inspectController.ShowName(itemName);
    }
    public void HideObjectName()
    {
        inspectController.HideName();
    }
    public void ShowExtraInfo()
    {
        inspectController.ShowAddiotionalInfo(itemExtraInfo);
    }
}
