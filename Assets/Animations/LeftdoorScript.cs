using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftdoorScript : MonoBehaviour, IPointerClickHandler
{
    Animator ldoor;
    //RightDoorScript rightDoorScript;
    // Start is called before the first frame update
    void Start()
    {
        ldoor = GetComponent<Animator>();
        //rightDoorScript = GameObject.Find("rightdoor-axis").GetComponent<RightDoorScript>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = ldoor.GetBool("ldooropen");
        ldoor.SetBool("ldooropen", !state);
        //if (rightDoorScript.isOpen)
        //{
        //    var state = ldoor.GetBool("ldooropen");
        //    ldoor.SetBool("ldooropen", !state);
        //}
    }
}
