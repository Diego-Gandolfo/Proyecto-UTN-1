using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoCamaraY : MonoBehaviour 
{
	public float VelocidadRotacionCamara;

	void Update ()
	{
		float VelocidadRotacion = VelocidadRotacionCamara * Time.deltaTime * (360 / 100);

//		if ((transform.eulerAngles.x >= -90) && (transform.eulerAngles.x <= 270))
//		{
		transform.Rotate (CrossPlatformInputManager.GetAxis ("Mouse Y") * VelocidadRotacion * (-1), 0, 0);
//		}
	}
}
