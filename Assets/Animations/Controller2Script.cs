using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Controller2Script : MonoBehaviour, IPointerClickHandler
{
    Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = animation.GetBool("Turned");
        animation.SetBool("Turned", !state);
    }
}
