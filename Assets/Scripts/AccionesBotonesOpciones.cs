using UnityEngine;
using System.Collections;

public class AccionesBotonesOpciones : MonoBehaviour 
{
	public void BotonDificultadMuyFacil()
	{
		GameManager.GM.Dificultad = 1;
	}

	public void BotonDificultadFacil()
	{
		GameManager.GM.Dificultad = 2;
	}

	public void BotonDificultadNormal()
	{
		GameManager.GM.Dificultad = 3;
	}
	
	public void BotonDificultadDificil()
	{
		GameManager.GM.Dificultad = 4;
	}
	
	public void BotonDificultadMuyDificil()
	{
		GameManager.GM.Dificultad = 5;
	}
}
