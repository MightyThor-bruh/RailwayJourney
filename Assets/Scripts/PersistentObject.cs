﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour
{
	public static PersistentObject Instance;
	private void Awake()
	{
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}
		// end of new code

		Instance = this;
		DontDestroyOnLoad(gameObject);
	}
}
