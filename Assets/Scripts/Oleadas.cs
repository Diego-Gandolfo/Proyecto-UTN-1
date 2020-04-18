using UnityEngine;
using System.Collections;

public class Oleadas : MonoBehaviour 
{
	public GameObject Prefab;
	public float Tiempo;
	
	void Awake () 
	{
		
		InvokeRepeating("Instanciador", 0, Tiempo);
	}
	
	void Instanciador()
	{
		Instantiate (Prefab, transform.position, transform.rotation);
	}
}