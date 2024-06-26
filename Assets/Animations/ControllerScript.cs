using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerScript : MonoBehaviour, IPointerClickHandler
{
    Animator animation_controls;
    // Start is called before the first frame update
    void Start()
    {
        animation_controls  = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = animation_controls.GetBool("IsTurned");
        animation_controls.SetBool("IsTurned", !state);
    }
}
