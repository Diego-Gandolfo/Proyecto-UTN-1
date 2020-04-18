using UnityEngine;
using System.Collections;

public class Mirador : MonoBehaviour 
{
	void Update () 
	{
		PuntoMirador vPuntoMirador = gameObject.GetComponent<PuntoMirador>();

		if (vPuntoMirador != null)
		{
			gameObject.transform.LookAt (vPuntoMirador.Objeto.transform.position);
		}
	}
}
