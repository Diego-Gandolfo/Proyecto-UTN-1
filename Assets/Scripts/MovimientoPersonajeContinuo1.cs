using UnityEngine;
using System.Collections;

public class MovimientoPersonajeContinuo1 : MonoBehaviour
{
	public float VelocidadCaminar;
	public float VelocidadCorrer;

	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftShift))
		{
			transform.Translate (VelocidadCorrer * Time.deltaTime * (-1), 0, 0);
		}
		else
		{
			transform.Translate (VelocidadCaminar * Time.deltaTime * (-1), 0, 0);
		}
	}
}
