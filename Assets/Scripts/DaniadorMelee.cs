using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DaniadorMelee : MonoBehaviour
{
	public float vDañoBase;
	public float vDaño;

	void OnTriggerStay(Collider vObjetoColisionado)
	{
		Vida vVida = vObjetoColisionado.GetComponent<Vida>();

		vDaño = vDañoBase * GameManager.GM.Dificultad;
		
		if (vVida != null)
		{	
			vVida.VidaActual = vVida.VidaActual - vDaño;
		}
	}

}