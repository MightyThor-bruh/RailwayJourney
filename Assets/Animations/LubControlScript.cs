using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LubControlScript : MonoBehaviour, IPointerClickHandler
{
    Animator animm;
    // Start is called before the first frame update
    void Start()
    {
        animm = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = animm.GetBool("goround");
        animm.SetBool("goround", !state);
    }
}
