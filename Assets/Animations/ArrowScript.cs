using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrowScript : MonoBehaviour, IPointerClickHandler
{
    Animator arrow;
    // Start is called before the first frame update
    void Start()
    {
        arrow = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = arrow.GetBool("arr");
        arrow.SetBool("arr", !state);
    }
}
