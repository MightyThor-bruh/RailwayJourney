using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int sensivity = 1;
    [SerializeField]
    int maxdistance = 33;
    [SerializeField]
    int mindistance = -150;

    [SerializeField]
    public Transform targetPos;


    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // кнопки A D 
        float y = Input.GetAxis("Vertical"); // кнопки W S 

        if (x != 0 || y != 0)
        {
            Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            //if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
            //    transform.position = newpos;
            transform.position = newpos;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -26, 29),
                             Mathf.Clamp(transform.position.y, 3, 33),
                             Mathf.Clamp(transform.position.z, -117, -58));
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
            //if (ControlDistance(Vector3.Distance(newpos, targetPos.position)))
            //    transform.position = newpos;
            transform.position = newpos;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -26, 29),
                                  Mathf.Clamp(transform.position.y, 3, 33),
                                  Mathf.Clamp(transform.position.z, -117, -58));
        }

        if (Input.GetMouseButton(1))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -26, 35),
                      Mathf.Clamp(transform.position.y, 3, 33),
                      Mathf.Clamp(transform.position.z, -125, -58));
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
            //transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);           
        }
    }

    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool move = false;
    Vector3 startPosition;
    Vector3 needPosition;
    Quaternion startRotation;
    Quaternion needRotation;
    float speed = 0.01f;
    float offset = 0;


    public void MoveRaspylitel()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-8f, 17f, -87f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);

        }

    }
    public void MoveRaspylitelRight()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(10f, 17f, -86f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);

        }

    }

    public void Move()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(2.95f, 20f, -110.28f);
            needRotation = Quaternion.Euler(6.977f, 0f, 0f);

        }

    }

    public void MoveRychagZaslonki()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(1f, 15f, -88f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveDoor()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(0.25f, 8f, -88f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveRychagPodachiMasla()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-12.5f, 13f, -88.5f);
            needRotation = Quaternion.Euler(0f, -12f, 0f);
        }

    }

    public void MoveKlapanLubrikatora()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-16.59f, 20f, -81.93f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveMagazinKlapan()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-6.61f, 24.52f, -80.28f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveWhistle()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(6f, 25f, -88f);
            needRotation = Quaternion.Euler(0f, 70f, 0f);
        }

    }

    public void MoveBashynKlapan()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-2.34f, 23.92f, -78.25f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveRightIngector()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(13f, 18.56f, -87f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveLeftIngector()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-13f, 18.73f, -87f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveKlapanKolba()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-10.54f, 11f, -92.56f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveKolba()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-10.54f, 11f, -92.56f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    public void MoveManometr()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            needRotation = transform.rotation;
            needPosition = new Vector3(-0.26f, 21.59f, -84.56f);
            needRotation = Quaternion.Euler(0f, 0f, 0f);
        }

    }

    void FixedUpdate()
    {

        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotation, offset);

            if (offset >= 1)
            {
                move = false;
                offset = 0;

            }
        }

    }
}

