using UnityEngine;
using System.Collections;

public class MovimientoPersonaje2 : MonoBehaviour 
{
	public float Velocidad;

	void Update () 
	{
		if (Input.GetKey (KeyCode.W))
		{
			transform.Translate (Velocidad * Time.deltaTime * (-1), 0, 0);
		} 
		else if (Input.GetKey (KeyCode.S))
		{
			transform.Translate (Velocidad * Time.deltaTime, 0, 0);
		}
		else if (Input.GetKey (KeyCode.A))
		{
			transform.Translate (0, 0, Velocidad * Time.deltaTime * (-1));
		}
		else if (Input.GetKey (KeyCode.D))
		{
			transform.Translate (0, 0, Velocidad * Time.deltaTime);
		}
	}
}