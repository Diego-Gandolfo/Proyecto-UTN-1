using UnityEngine;
using System.Collections;

public class MovimientoPersonaje3 : MonoBehaviour 
{
	public float Velocidad;
	
	void Update () 
	{
		if ((Input.GetKey (KeyCode.W))||(Input.GetKey (KeyCode.UpArrow)))
		{
			transform.Translate (Velocidad * Time.deltaTime * (-1), 0, 0);
		} 
		else if ((Input.GetKey (KeyCode.S))||(Input.GetKey (KeyCode.DownArrow)))
		{
			transform.Translate (Velocidad * Time.deltaTime, 0, 0);
		}
		else if ((Input.GetKey (KeyCode.A))||(Input.GetKey (KeyCode.LeftArrow)))
		{
			transform.Translate (0, 0, Velocidad * Time.deltaTime * (-1));
		}
		else if ((Input.GetKey (KeyCode.D))||(Input.GetKey (KeyCode.RightArrow)))
		{
			transform.Translate (0, 0, Velocidad * Time.deltaTime);
		}
	}
}