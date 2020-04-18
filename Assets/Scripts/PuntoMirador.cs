using UnityEngine;
using System.Collections;

public class PuntoMirador : MonoBehaviour
{
	public GameObject Objeto;

	public void Awake()
	{
		Objeto = GameObject.Find ("Personaje");
	}
}
