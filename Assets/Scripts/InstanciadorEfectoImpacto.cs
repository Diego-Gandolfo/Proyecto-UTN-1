using UnityEngine;
using System.Collections;

public class InstanciadorEfectoImpacto : MonoBehaviour 
{
	public GameObject EfectoParticulas;

	public void OnTriggerEnter(Collider ObjetoColisionado)
	{
		Enemigo vEnemigo = ObjetoColisionado.GetComponent<Enemigo>();
		
		if (vEnemigo != null)	Instantiate (EfectoParticulas, transform.position, transform.rotation);
	}
}
