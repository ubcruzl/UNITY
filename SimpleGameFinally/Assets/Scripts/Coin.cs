using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		//Destruye monedas, temporizador de 2 segundos
		Destroy(gameObject, 2.0f);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
