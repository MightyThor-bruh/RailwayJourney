using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RaspLeftScript : MonoBehaviour, IPointerClickHandler
{
    Animator raspleft;
    // Start is called before the first frame update
    void Start()
    {
        raspleft = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = raspleft.GetBool("turn");
        raspleft.SetBool("turn", !state);
    }
}
