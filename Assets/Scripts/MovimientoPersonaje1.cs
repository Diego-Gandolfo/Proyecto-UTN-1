using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoPersonaje1 : MonoBehaviour
{
	public float Velocidad;

	void Update ()
	{
		transform.Translate (CrossPlatformInputManager.GetAxis ("Vertical") * Velocidad * Time.deltaTime*(-1), 0, CrossPlatformInputManager.GetAxis ("Horizontal") * Velocidad * Time.deltaTime);
	}
}