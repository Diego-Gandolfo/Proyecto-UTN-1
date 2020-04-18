using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Disparador : MonoBehaviour 
{
	public GameObject Prefab;
	public AudioSource AudioSource1;
	public float Tiempo;

	void Update () 
	{

		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			InvokeRepeating("Instanciador", 0, Tiempo);
		}
		else if (CrossPlatformInputManager.GetButtonUp("Fire1"))
		{
			CancelInvoke("Instanciador");
		}
	}

	void Instanciador()
	{
		Instantiate (Prefab, transform.position, transform.rotation);
		AudioSource1.Play();
	}
}
