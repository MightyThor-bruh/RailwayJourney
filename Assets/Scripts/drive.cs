using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float speed = 4f; // Скорость перемещения объекта
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
