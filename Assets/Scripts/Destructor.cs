using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour
{
	public GameObject Objeto;

	void OnTriggerEnter(Collider ObjetoColisionado)
	{
		Vida VerificacionVida = ObjetoColisionado.GetComponent<Vida>();

		Instantiate (Objeto, transform.position, transform.rotation);
		Destroy (gameObject);

		if (VerificacionVida == null)
		{	
			Destroy (ObjetoColisionado.gameObject);
		}
	}
}
