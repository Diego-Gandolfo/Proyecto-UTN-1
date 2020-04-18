using UnityEngine;
using System.Collections;

public class ActivadorAutomatico : MonoBehaviour 
{
	public GameObject Objeto;
	public float Tiempo;
	private float Acumulador;

	void Update () 
	{
		Acumulador += Time.deltaTime;
		
		if ((Acumulador >= Tiempo) && (Objeto != null))
		{
			Objeto.SetActive(true);
		}
	}
}
