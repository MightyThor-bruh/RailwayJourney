using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
	//public Transform target; // Объект, за которым следит камера
	//public Vector3 offset = new Vector3(0, 0, 0); // Смещение камеры

	//void LateUpdate()
	//{
	//	transform.position = target.position + offset;
	//}
	public Transform target; // Объект, за которым следит камера
	public float smooth = 5.0f; // Скорость следования

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	void Update()
	{
		transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
	}
}
