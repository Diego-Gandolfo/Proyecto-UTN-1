using UnityEngine;
using System.Collections;

public class RotacionContinua : MonoBehaviour 
{
	public float VelocidadRotacionX;
	public float VelocidadRotacionY;
	public float VelocidadRotacionZ;

	public void Update ()
	{
		transform.Rotate (VelocidadRotacionX * Time.deltaTime * 30, 0, 0);
		transform.Rotate (0, VelocidadRotacionY * Time.deltaTime * 30, 0);
		transform.Rotate (0, 0, VelocidadRotacionZ * Time.deltaTime * 30);
	}
}
