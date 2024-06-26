using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class RychagMaslaScript : MonoBehaviour, IPointerClickHandler
{
    Animator animatorr;
    // Start is called before the first frame update
    void Start()
    {
        animatorr = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = animatorr.GetBool("push");
        animatorr.SetBool("push", !state);
    }
}
