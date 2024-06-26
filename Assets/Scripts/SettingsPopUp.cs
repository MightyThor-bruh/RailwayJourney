using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopUp : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        Close();
    }

    public void OnOpenSettings()
    {
        Open(); 				//  Открываем всплывающее окно. 
    }

    public void Open()
    {
        gameObject.SetActive(true);        //   Активируем объект, чтобы открыть окно.  
    }
    public void Close()
    {
        gameObject.SetActive(false);      // Деактивируем объект, чтобы закрыть окно.  
    }

}
