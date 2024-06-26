using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButtonScript : MonoBehaviour
{
    public GameObject button;
    
    public void ShowButton()
    {
        button.SetActive(true);
    }
}
