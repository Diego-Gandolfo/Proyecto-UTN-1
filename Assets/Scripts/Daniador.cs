using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Daniador : MonoBehaviour
{
	public float Danio;

	void OnTriggerEnter(Collider ObjetoColisionado)
	{
		Vida VerificacionVida = ObjetoColisionado.GetComponent<Vida>();

		if (VerificacionVida != null)
		{	
			VerificacionVida.VidaActual = VerificacionVida.VidaActual - Danio;
		}

		Destroy (gameObject);
	}
}