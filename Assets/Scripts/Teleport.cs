using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		// Проверяем, столкнулись ли мы с игроком
		if (other.gameObject.tag == "Player")
		{
			// Загружаем следующую сцену
			SceneManager.LoadScene("CabinScene", LoadSceneMode.Single);
			//Выгружаем старую сцену
			//SceneManager.UnloadSceneAsync("StationScene");
		}
	}
}
