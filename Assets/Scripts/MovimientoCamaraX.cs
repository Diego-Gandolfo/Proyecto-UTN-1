using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoCamaraX : MonoBehaviour 
{
	public float VelocidadRotacionCamara;

	void Update ()
	{
		float VelocidadRotacion = VelocidadRotacionCamara * Time.deltaTime * (360 / 100);

		transform.Rotate (0, CrossPlatformInputManager.GetAxis ("Mouse X") * VelocidadRotacion, 0);
	}
}
