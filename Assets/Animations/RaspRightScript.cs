using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaspRightScript : MonoBehaviour, IPointerClickHandler
{
    Animator raspright;
    // Start is called before the first frame update
    void Start()
    {
        raspright = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = raspright.GetBool("raspturn");
        raspright.SetBool("raspturn", !state);
    }
}
