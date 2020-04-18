using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vida : MonoBehaviour 
{
	public float VidaBase;
	public float VidaMaxima;
	public float VidaActual;

	void Start ()
	{

		if (gameObject.name == "Personaje")
//			VidaMaxima = VidaBase / GameManager.GM.Dificultad;
			VidaMaxima = VidaBase;
		else
			VidaMaxima = VidaBase * GameManager.GM.Dificultad;

		VidaActual = VidaMaxima;
	}

	void Update ()
	{
		if (VidaActual <= 0)
		{
			SendMessage("Mori", SendMessageOptions.DontRequireReceiver);

			if (gameObject.name != "Personaje")
			{
				Destroy (gameObject);
			}
		}
	}
}