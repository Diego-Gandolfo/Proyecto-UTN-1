using UnityEngine;
using System.Collections;

public class MovimientoContinuo : MonoBehaviour
{
	public float VelocidadMovimientoX;
	public float VelocidadMovimientoY;
	public float VelocidadMovimientoZ;

	public void Update () 
	{
		transform.Translate (VelocidadMovimientoX * Time.deltaTime, 0, 0);
		transform.Translate (0, VelocidadMovimientoY * Time.deltaTime, 0);
		transform.Translate (0, 0, VelocidadMovimientoZ * Time.deltaTime);
	}
}
