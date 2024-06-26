using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
	public Slider brightnessSlider; // Ссылка на UI Slider

	private float minBrightness = 0.1f; // Минимальное значение яркости
	private float maxBrightness = 1f; // Максимальное значение яркости

	private void Start()
	{
		// Начальное значение яркости (можно установить по умолчанию)
		float initialBrightness = 0.5f;
		SetBrightness(initialBrightness);
	}

	// Вызывается при изменении значения слайдера
	public void OnBrightnessChanged(float value)
	{
		// Преобразование значения слайдера в диапазон яркости
		float brightness = Mathf.Lerp(minBrightness, maxBrightness, value);
		SetBrightness(brightness);
	}

	// Устанавливает яркость для всех объектов (пример)
	private void SetBrightness(float brightness)
	{
		// Примените изменение яркости к вашим объектам или другим параметрам
		RenderSettings.ambientIntensity = brightness; // Пример для окружающего освещения


		// Отображение текущего значения яркости (например, в текстовом поле)
		Debug.Log($"Яркость: {brightness}");
	}
}
