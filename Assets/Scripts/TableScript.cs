using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class TableScript : MonoBehaviour
{
    public TextMeshProUGUI newValue1;
    public TextMeshProUGUI newValue2;
    public TextMeshProUGUI newValue3;
    public InputField textInput;
    public TextMeshProUGUI speed1;
    public TextMeshProUGUI speed2;
    public TextMeshProUGUI speed3;
    public TextMeshProUGUI water1;
    public TextMeshProUGUI water2;
    public TextMeshProUGUI water3;

    //функция для кнопки «Записать»
    public void WriteValue()
    {
        if (newValue1.text == "-")
            newValue1.text = textInput.text.ToString();
        else if (newValue1.text == "-")
        {
            newValue1.text = textInput.text.ToString();
            speed1.text = ((int.Parse(newValue1.text) * int.Parse(water1.text)) / 6).ToString();
        }
        else if (newValue2.text == "-")
            newValue2.text = textInput.text.ToString();
        else if (newValue2.text == "-")
        {
            newValue2.text = textInput.text.ToString();
            speed2.text = ((int.Parse(newValue2.text) * int.Parse(water2.text)) / 6).ToString();
        }
        else if (newValue3.text == "-")
            newValue3.text = textInput.text.ToString();
        else if (newValue3.text == "-")
        {
            newValue3.text = textInput.text.ToString();
            speed3.text = ((int.Parse(newValue3.text) * int.Parse(water3.text)) / 6).ToString();
        }
        textInput.text = "";
    }
    //функция для кнопки «Очистить»
    public void Clean()
    {
        newValue1.text = "-";
        newValue2.text = "-";
        newValue3.text = "-";
        speed1.text = "-";
        speed2.text = "-";
        speed3.text = "-";
    }

    public void Count()
    {
        if (speed1.text == "-" && newValue1.text != "-")
        {
            speed1.text = ((int.Parse(newValue1.text) * int.Parse(water1.text)) / 6).ToString();
        }
        if (speed2.text == "-" && newValue2.text != "-")
        {
            speed2.text = ((int.Parse(newValue2.text) * int.Parse(water2.text)) / 6).ToString();
        }
        if (speed3.text == "-" && newValue3.text != "-")
        {
            speed3.text = ((int.Parse(newValue3.text) * int.Parse(water3.text)) / 6).ToString();
        }
    }

}
