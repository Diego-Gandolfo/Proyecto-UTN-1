using UnityEngine;
using System.Collections;

public class DisparadorAutomatico : MonoBehaviour 
{
	public GameObject Prefab;
	public AudioSource AudioSource1;
	public float Tiempo;
	
	void Awake () 
	{
		
		InvokeRepeating("Instanciador", 0, Tiempo);
	}
	
	void Instanciador()
	{
		Instantiate (Prefab, transform.position, transform.rotation);
		AudioSource1.Play();
	}
}