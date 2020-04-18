using UnityEngine;
using System.Collections;

public class MoverRotarContinuamente : MonoBehaviour 
{
	public float VelocidadMovimientoX;
	public float VelocidadMovimientoY;
	public float VelocidadMovimientoZ;
	public float VelocidadRotacionX;
	public float VelocidadRotacionY;
	public float VelocidadRotacionZ;

	public void Update () 
	{
		transform.Translate (VelocidadMovimientoX * Time.deltaTime, 0, 0);
		transform.Translate (0, VelocidadMovimientoY * Time.deltaTime, 0);
		transform.Translate (0, 0, VelocidadMovimientoZ * Time.deltaTime);

		transform.Rotate (VelocidadRotacionX * Time.deltaTime * 30, 0, 0);
		transform.Rotate (0, VelocidadRotacionY * Time.deltaTime * 30, 0);
		transform.Rotate (0, 0, VelocidadRotacionZ * Time.deltaTime * 30);
	}

}