using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HidePanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public TextMeshProUGUI taskText;
    public TextMeshProUGUI notion;

    public void ShowPanel()
    {
        if (panel.activeSelf)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
    public void CloseButton()
    {
        button.SetActive(false);
    }

    public void Task1()
    {
        taskText.text = "Открыть правый и левый водяной инжектор";
    }

    public void Task2()
    {
        taskText.text = "Открыть клапан лубрикатора паровоздушного насоса";
    }

    public void Task3()
    {
        taskText.text = "Открыть левый и правый распылитель";
    }

    public void Task4()
    {
        taskText.text = "Потянуть рычаг подачи масла";
    }

    public void Task5()
    {
        taskText.text = "Открыть магазинный воздушный клапан";
    }

    public void Task6()
    {
        taskText.text = "Открыть топку и убедиться, что огонь достаточно разгорелся";
    }

    public void Task7()
    {
        taskText.text = "Дождаться, когда стрелка на манометре прекратит ход.";
    }

    public void Task8()
    {
        taskText.text = "Потянуть рычаг заслонки";
    }

    public void Task9()
    {
        taskText.text = "Потянуть шнур свистка";
    }

    //public void Task10()
    //{
    //    taskText.text = "Потянуть рычаг заслонки";
    //}

    //public void Task11()
    //{
    //    taskText.text = "Потянуть шнур свистка";
    //}

    public void RaspylitelNotion()
    {
        notion.text = "Распыляет мазут и отправляет его в топку, чтобы поддерживать огонь";
    }

    public void RychagZaslonkiNotion()
    {
        notion.text = "Регулирует мощность подачи пара";
    }

    public void RychagMaslaNotion()
    {
        notion.text = "Используется для точного контроля масла, направляемого в распылитель";
    }

    public void DoorNotion()
    {
        notion.text = "Используется для открытия и закрытия топки";
    }

    public void KlapanLubrikatoraNotion()
    {
        notion.text = "Включает подачу пара для включения лубрикатора и запуска насоса";
    }

    public void MagazinKlapanNotion()
    {
        notion.text = "Обеспечивает быстрый набор давления";
    }

    public void KolbaNotion()
    {
        notion.text = "Показывает уровень воды в тендере";
    }

    public void KolbaKlapanNotion()
    {
        notion.text = "Используется для промывки мерной колбы";
    }

    public void ManometrNotion()
    {
        notion.text = "Показывает давление в котле";
    }

    public void IngectorNotion()
    {
        notion.text = "Впрыскивает воду из тендера в котел";
    }

    public void WhistleNotion()
    {
        notion.text = "Дает сигнал об отправлении или прибытии паровоза";
    }

    public void BashenKlapanNotion()
    {
        notion.text = "Регулирует движение всего пара к органам управления в кабине";
    }
}
