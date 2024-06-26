using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MagazControlScript : MonoBehaviour, IPointerClickHandler
{
    Animator animatia;
    // Start is called before the first frame update
    void Start()
    {
        animatia = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var state = animatia.GetBool("round");
        animatia.SetBool("round", !state);
    }
}
