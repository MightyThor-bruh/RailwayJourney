using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WireScript : MonoBehaviour, IPointerClickHandler
{
    Animator aanim;
    // Start is called before the first frame update
    void Start()
    {
        aanim = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = aanim.GetBool("pulled");
        aanim.SetBool("pulled", !state);
    }
}
