using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoPersonaje : MonoBehaviour 
{
	public float VelocidadCaminar;
	public float VelocidadCorrer;

	void FixedUpdate () 
	{
		if (CrossPlatformInputManager.GetAxis("Fire3") == 1)
		{
			transform.Translate (CrossPlatformInputManager.GetAxis ("Horizontal") * VelocidadCorrer * Time.deltaTime,
			                     0, 
			                     CrossPlatformInputManager.GetAxis ("Vertical") * VelocidadCorrer * Time.deltaTime);
		}
		else
		{
			transform.Translate (CrossPlatformInputManager.GetAxis ("Horizontal") * VelocidadCaminar * Time.deltaTime,
			                     0, 
			                     CrossPlatformInputManager.GetAxis ("Vertical") * VelocidadCaminar * Time.deltaTime);
		}
	}
}