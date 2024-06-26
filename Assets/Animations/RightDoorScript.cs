using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightDoorScript : MonoBehaviour, IPointerClickHandler
{
    Animator rdoor;
    //public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        rdoor = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = rdoor.GetBool("rdooropen");
        rdoor.SetBool("rdooropen", !state);
        //Debug.Log(isOpen);
        //if (isOpen == false)
        //{
        //    var state = rdoor.GetBool("rdooropen");
        //    rdoor.SetBool("rdooropen", !state);
        //}
        //else
        //{
        //    isOpen = true;
        //}      
    }
}
